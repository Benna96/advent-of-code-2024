using FluentAssertions.Execution;

namespace AdventOfCode2024.Tests;

public sealed class Day01Tests : BaseProblemTests<Day01>
{
    protected override Day01 GivenProblem { get; } = new(GivenInput);

    private static string GivenInput => """
                                        3   4
                                        4   3
                                        2   5
                                        1   3
                                        3   9
                                        3   3
                                        """;

    private static IReadOnlyList<int> ExpectedLeftIds => [3, 4, 2, 1, 3, 3];
    private static IReadOnlyList<int> ExpectedRightIds => [4, 3, 5, 3, 9, 3];

    protected override string ExpectedPart1Solution => "11";
    protected override string ExpectedPart2Solution => "31";

    [Fact]
    public override void InputIsParsedCorrectly()
    {
        var parsed = Day01.ParseInput(GivenInput);

        using (new AssertionScope())
        {
            parsed.leftIds.Should().BeEquivalentTo(ExpectedLeftIds, "values should match input's first column");
            parsed.rightIds.Should().BeEquivalentTo(ExpectedRightIds, "values should match input's second column");
        }
    }
}