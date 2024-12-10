// ReSharper disable once CheckNamespace
namespace AoCHelper;

/// <summary>
/// Utility functions for BaseProblem classes.
/// The base classes are in a package, so can't edit them myself.<br/>
/// I'd prefer to have these as protected tbh, but it is what it is...
/// </summary>
public static class BaseProblemExtensions
{
    public static string FetchInput(
        this BaseProblem self,
        string? inputOverride = null)
    {
        if (inputOverride is not null)
            return inputOverride;
        
        if (File.Exists(self.InputFilePath))
            return File.ReadAllText(self.InputFilePath);

        return "";
    }
}