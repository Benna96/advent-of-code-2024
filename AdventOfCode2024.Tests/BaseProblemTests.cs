using AoCHelper;
using FluentAssertions.Common;

namespace AdventOfCode2024.Tests;

public abstract class BaseProblemTests<TProblem>
    where TProblem : BaseProblem
{
    protected abstract TProblem GivenProblem { get; }

    protected abstract string ExpectedPart1Solution { get; }
    protected abstract string ExpectedPart2Solution { get; }
    
    [Fact]
    public void CanBeInstantiatedBySolver()
    {
        typeof(TProblem).Should().HaveDefaultConstructor()
            .Which.Should().HaveAccessModifier(CSharpAccessModifier.Public);
    }
    
    /// <summary>
    /// Abstract, because input can be parsed to practically anything.
    /// </summary>
    [Fact]
    public abstract void InputIsParsedCorrectly();

    [Fact]
    public virtual async Task Part1IsSolvedCorrectly()
    {
        var solution = await GivenProblem.Solve_1();
        solution.Should().Be(ExpectedPart1Solution);
    }

    [Fact]
    public virtual async Task Part2IsSolvedCorrectly()
    {
        var solution = await GivenProblem.Solve_2();
        solution.Should().Be(ExpectedPart2Solution);
    }
}