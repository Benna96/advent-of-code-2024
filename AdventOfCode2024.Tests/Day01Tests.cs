namespace AdventOfCode2024.Tests;

public class Day01Tests
{
    private static Day01 Day => new();

    private static readonly string DemoInput = "TEMP";

    [Fact]
    public void InputParsingIsWip()
    {
        var inputParser = () => Day01.ParseInput(DemoInput);
        inputParser.Should().Throw<NotImplementedException>();
    }
    
    [Fact]
    public async Task Part1SolverIsWip()
    {
        var solver1 = async () => await Day.Solve_1();
        await solver1.Should().ThrowAsync<NotImplementedException>();
    }

    [Fact]
    public async Task Part2SolverIsWip()
    {
        var solver2 = async () => await Day.Solve_2();
        await solver2.Should().ThrowAsync<NotImplementedException>();
    }
}