using System.Text.RegularExpressions;

namespace AdventOfCode2024;

public sealed class Day03 : BaseDay
{
    private readonly IReadOnlyList<string> _validInstructions;
    
    public Day03() : this(null) { }

    public Day03(string? inputOverride = null)
    {
        var input = this.FetchInput(inputOverride);
        _validInstructions = ParseInput(input);
    }
    
    public static IReadOnlyList<string> ParseInput(string input)
    {
        var regex = new Regex(@"mul\(\d{1,3},\d{1,3}\)");
        var matches = regex.Matches(input);
        var validInstructions = matches.Select(x => x.ToString());
        return validInstructions.ToList().AsReadOnly();
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