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
        var input = customInput ?? File.ReadAllText(InputFilePath);
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
        throw new NotImplementedException();
    }

    public override ValueTask<string> Solve_2()
    {
        throw new NotImplementedException();
    }
}