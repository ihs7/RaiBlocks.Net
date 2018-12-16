namespace RaiBlocks.Interfaces
{
    public interface IAction<TResult> : IAction
    {
        string Action { get; }
    }

    public interface IAction
    { }
}
