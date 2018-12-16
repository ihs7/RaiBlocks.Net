namespace RaiBlocks.Interfaces
{
    public interface IActionResultWithError : IActionResult
    {
        string Error { get; set; }
    }
}
