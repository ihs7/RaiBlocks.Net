using System.Threading.Tasks;

namespace RaiBlocks.Interfaces
{
    public interface IActionHandler<TAction, TResult> 
        where TAction : class, IAction<TResult>
        where TResult : class, IActionResult
    {
        Task<TResult> Handle(TAction action);
    }
}
