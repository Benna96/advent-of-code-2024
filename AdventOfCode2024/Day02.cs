namespace AdventOfCode2024;

public sealed class Day02 : BaseDay
{
    private readonly IReadOnlyList<IReadOnlyList<int>> _levelReports;
    
    public Day02() : this(null) { }

    public Day02(string? inputOverride = null)
    {
        var input = this.FetchInput(inputOverride);
        _levelReports = ParseInput(input);
    }

    public static IReadOnlyList<IReadOnlyList<int>> ParseInput(string input)
    {
        List<IReadOnlyList<int>> levelReports = [];
        
        using var reader = new StringReader(input);
        while (reader.ReadLine() is { } line)
        {
            var levels = line.Split(' ').Select(int.Parse);
            levelReports.Add(levels.ToList().AsReadOnly());
        }
        
        return levelReports;
    }

    public override ValueTask<string> Solve_1()
    {
        var safeReports = _levelReports.Where(IsSafe);
        return new ValueTask<string>(safeReports.Count().ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        var safeReports = _levelReports.Where(report =>
        {
            if (IsSafe(report))
                return true;

            for (var i = 0; i < report.Count; i++)
            {
                var reportWithoutLevel = report.ToList();
                reportWithoutLevel.RemoveAt(i);
                var isSafe = IsSafe(reportWithoutLevel);
                if (isSafe)
                    return true;
            }
            
            return false;
        });

        return new ValueTask<string>(safeReports.Count().ToString());
    }

    private static bool IsSafe(IReadOnlyList<int> report)
    {
        bool? increasingOverall = null;
        
        for (var i = 1; i < report.Count; ++i)
        {
            var diff = report[i] - report[i - 1];
            
            if (Math.Abs(diff) is < 1 or > 3)
                return false;

            var increasing = diff > 0;
            increasingOverall ??= increasing;
            if (increasing != increasingOverall)
                return false;
        }

        return true;
    }
}