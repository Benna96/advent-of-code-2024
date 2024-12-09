using FluentAssertions.Execution;

namespace AdventOfCode2024.Tests;

public class Day01Tests
{
    private static Day01 GivenDay => new(GivenInput);

    private static readonly string GivenInput = """
                                               3   4
                                               4   3
                                               2   5
                                               1   3
                                               3   9
                                               3   3
                                               """;

    private static readonly IReadOnlyList<int> ExpectedLeftIds = [3, 4, 2, 1, 3, 3];
    private static readonly IReadOnlyList<int> ExpectedRightIds = [4, 3, 5, 3, 9, 3];

    [Fact]
    public void InputIsParsedCorrectly()
    {
        var parsed = Day01.ParseInput(GivenInput);

        using (new AssertionScope())
        {
            parsed.leftIds.Should().BeEquivalentTo(ExpectedLeftIds, "values should match input's first column");
            parsed.rightIds.Should().BeEquivalentTo(ExpectedRightIds, "values should match input's second column");
        }
    }
    
    [Fact]
    public async Task Part1SolverIsWip()
    {
        var solver1 = async () => await GivenDay.Solve_1();
        await solver1.Should().ThrowAsync<NotImplementedException>();
    }

    [Fact]
    public async Task Part2SolverIsWip()
    {
        var solver2 = async () => await GivenDay.Solve_2();
        await solver2.Should().ThrowAsync<NotImplementedException>();
    }
}