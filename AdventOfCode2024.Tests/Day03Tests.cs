namespace AdventOfCode2024.Tests;

public sealed class Day03Tests : BaseProblemTests<Day03>
{
    protected override Day03 GivenProblem { get; } = new(GivenInput);

    private static string GivenInput => "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";

    private static IReadOnlyList<string> ExpectedValidInstructionsPart1 =>
        ["mul(2,4)", "mul(5,5)", "mul(11,8)", "mul(8,5)"];

    private static string GivenInput2 => "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";

    private static IReadOnlyList<string> ExpectedValidInstructionsPart2 =>
        ["mul(2,4)", "mul(8,5)"];

    protected override string ExpectedPart1Solution => "161";
    protected override string ExpectedPart2Solution => "48";

    public override void InputIsParsedCorrectly()
    {
        var parsed = Day03.ParseInputPart1(GivenInput);
        parsed.Should().BeEquivalentTo(ExpectedValidInstructionsPart1);
        
        var parsed2 = Day03.ParseInputPart2(GivenInput2);
        parsed2.Should().BeEquivalentTo(ExpectedValidInstructionsPart2);
    }
    
    /// <summary>
    /// Need to override because uses different input,
    /// base class only supports same obj for both
    /// &amp; current impl has 1 input per obj
    /// </summary>
    public override async Task Part2IsSolvedCorrectly()
    {
        var solution = await new Day03(GivenInput2).Solve_2();
        solution.Should().Be(ExpectedPart2Solution);
    }
}