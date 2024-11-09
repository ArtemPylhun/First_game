using Code.Runtime.Infrastructure.GameStates.Api;
using Code.Runtime.Infrastructure.GameStates.StateMachine;
using Code.Runtime.Infrastructure.Services.Scene;

namespace Code.Runtime.Infrastructure.GameStates.State
{
    public class BootstrapState: IEnterableState
    {
        private const string LevelName = "Level";
        public string BootstrapSceneName = "BootstrapScene";
        private readonly IGameStateMachine _stateMachine;
        private ISceneLoader _sceneLoader;

        public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }
        public void Enter()
        {
            _sceneLoader.LoadScene(BootstrapSceneName);
            _sceneLoader.LoadScene(LevelName);
            _stateMachine.Enter<LevelState>();
        }

    }
}