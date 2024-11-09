using Code.Runtime.Infrastructure.GameStates.Api;
using Code.Runtime.Infrastructure.GameStates.Provider;
using UnityEngine;

namespace Code.Runtime.Infrastructure.GameStates.StateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly IStateProvider _stateProvider;
        private IState _activeState;

        public GameStateMachine(IStateProvider stateProvider)
        {
            _stateProvider = stateProvider;
        }

        public void Enter<TState>()
            where TState : class, IEnterableState
        {
            IEnterableState state = GetState<TState>();

            if (_activeState is IExitableState activeState)
                activeState?.Exit();
            
            Debug.Log($"GameStateMachine entered <color=blue>{state.GetType().Name}</color>");
            state.Enter();
        }

        private TState GetState<TState>()
            where TState : class, IEnterableState => 
            _stateProvider.GetState<TState>();
    }
}