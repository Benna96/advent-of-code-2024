namespace AdventOfCode2024;

/// <summary>
/// <see href="https://adventofcode.com/2024/day/1">Link to puzzle</see> 
/// </summary>
public sealed class Day01 : BaseDay
{
    private readonly IReadOnlyList<int> _leftIds;
    private readonly IReadOnlyList<int> _rightIds;
    
    public Day01() : this(null) { }

    public Day01(string? customInput = null)
    {
        var input = this.FetchInput(customInput);
        (_leftIds, _rightIds) = ParseInput(input);
    }
    
    public static (IReadOnlyList<int> leftIds, IReadOnlyList<int> rightIds) ParseInput(string input)
    {
        List<int> leftIds = [];
        List<int> rightIds = [];
        
        using var reader = new StringReader(input);
        while (reader.ReadLine() is { } line)
        {
            var lineIds = line.Split("   ");
            leftIds.Add(int.Parse(lineIds[0]));
            rightIds.Add(int.Parse(lineIds[1]));
        }
        
        return (leftIds.AsReadOnly(), rightIds.AsReadOnly());
    }

    public override ValueTask<string> Solve_1()
    {
        var leftSorted = _leftIds.Order();
        var rightSorted = _rightIds.Order();

        var pairs = leftSorted.Zip(rightSorted, (l, r) => new { l, r });
        var distanceSum = pairs.Sum(pair => Math.Abs(pair.l - pair.r));
        
        return new ValueTask<string>(distanceSum.ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        Dictionary<int, int> rightIdCounts = [];
        foreach (var id in _rightIds)
        {
            var idCount = rightIdCounts.GetValueOrDefault(id, 0);
            ++idCount;
            rightIdCounts[id] = idCount;
        }
        
        var similarityScore = _leftIds.Sum(id => id * rightIdCounts.GetValueOrDefault(id, 0));
        
        return new ValueTask<string>(similarityScore.ToString());
    }
}