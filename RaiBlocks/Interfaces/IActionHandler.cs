using System.Threading.Tasks;

namespace RaiBlocks.Interfaces
{
    public interface IActionHandler<TAction, TResult> where TAction : IAction<TResult>
    {
        Task<TResult> Handle(TAction action);
    }
}
