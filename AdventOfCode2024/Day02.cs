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
        throw new NotImplementedException();
    }

    public override ValueTask<string> Solve_2()
    {
        throw new NotImplementedException();
    }
}