namespace AdventOfCode2024.Tests;

public sealed class Day02Tests : BaseProblemTests<Day02>
{
    protected override Day02 GivenProblem { get; } = new(GivenInput);

    private static string GivenInput => """
                                        7 6 4 2 1
                                        1 2 7 8 9
                                        9 7 6 2 1
                                        1 3 2 4 5
                                        8 6 4 4 1
                                        1 3 6 7 9
                                        """;

    private static IReadOnlyList<IReadOnlyList<int>> ExpectedLevelReports =>
    [
        [7, 6, 4, 2, 1],
        [1, 2, 7, 8, 9],
        [9, 7, 6, 2, 1],
        [1, 3, 2, 4, 5],
        [8, 6, 4, 4, 1],
        [1, 3, 6, 7, 9],
    ];

    protected override string ExpectedPart1Solution => "2";
    protected override string ExpectedPart2Solution => "4";

    public override void InputIsParsedCorrectly()
    {
        var parsed = Day02.ParseInput(GivenInput);
        parsed.Should().BeEquivalentTo(ExpectedLevelReports);
    }
}