namespace AdventOfCode2024.Tests;

public sealed class Day03Tests : BaseProblemTests<Day03>
{
    protected override Day03 GivenProblem { get; } = new(GivenInput);

    private static string GivenInput => "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";

    private static IReadOnlyList<string> ExpectedValidInstructions =>
        ["mul(2,4)", "mul(5,5)", "mul(11,8)", "mul(8,5)"];

    protected override string ExpectedPart1Solution => "161";
    protected override string ExpectedPart2Solution => "TODO";

    public override void InputIsParsedCorrectly()
    {
        var parsed = Day03.ParseInput(GivenInput);
        parsed.Should().BeEquivalentTo(ExpectedValidInstructions);
    }
    
    [Fact(Skip = "TODO")]
    public override Task Part2IsSolvedCorrectly()
    {
        return base.Part2IsSolvedCorrectly();
    }
}