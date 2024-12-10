using System.Text.RegularExpressions;

namespace AdventOfCode2024;

public sealed class Day03 : BaseDay
{
    private readonly IReadOnlyList<string> _validInstructions;
    private readonly IReadOnlyList<string> _validInstructionsPart2;
    
    public Day03() : this(null) { }

    public Day03(string? inputOverride = null)
    {
        var input = this.FetchInput(inputOverride);
        _validInstructions = ParseInputPart1(input);
        _validInstructionsPart2 = ParseInputPart2(input);
    }
    
    public static IReadOnlyList<string> ParseInputPart1(string input)
    {
        var regex = new Regex(@"mul\(\d{1,3},\d{1,3}\)");
        var matches = regex.Matches(input);
        var validInstructions = matches.Select(x => x.ToString());
        return validInstructions.ToList().AsReadOnly();
    }

    public static IReadOnlyList<string> ParseInputPart2(string input)
    {
        var mulRegex = @"mul\(\d{1,3},\d{1,3}\)";
        var doRegex = @"do\(\)";
        var dontRegex = @"don't\(\)";
        
        var regex = new Regex($@"(?<mul>{mulRegex})|(?<do>{doRegex})|(?<dont>{dontRegex})");
        var matches = regex.Matches(input);

        var valid = true;
        List<string> validInstructions = [];

        foreach (Match match in matches)
        {
            var group = match.Groups.Values.Skip(1).First(x => x.Success)!;
            
            switch (group.Name)
            {
                case "mul":
                    if (valid)
                    {
                        validInstructions.Add(group.Value);
                    }
                    break;
                
                case "do":
                    valid = true;
                    break;
                
                case "dont":
                    valid = false;
                    break;
            }
        }

        return validInstructions.AsReadOnly();
    }

    public override ValueTask<string> Solve_1()
    {
        var numRegex = new Regex(@"\d{1,3}");
        var sum = _validInstructions.Sum(instruction =>
        {
            var nums = numRegex.Matches(instruction).Select(x => int.Parse(x.ToString()));
            return nums.Aggregate(1, (current, num) => current * num);
        });
        
        return new ValueTask<string>(sum.ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        throw new NotImplementedException();
    }
}