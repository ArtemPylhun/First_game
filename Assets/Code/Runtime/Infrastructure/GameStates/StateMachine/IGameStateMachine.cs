using Code.Runtime.Infrastructure.GameStates.Api;

namespace Code.Runtime.Infrastructure.GameStates.StateMachine
{
    public interface IGameStateMachine
    {
        void Enter<TState>()
            where TState : class, IEnterableState;
    }
}