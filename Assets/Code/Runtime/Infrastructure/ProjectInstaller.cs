using Code.Runtime.Infrastructure.Services;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Runtime.Infrastructure
{
    public class ProjectInstaller: MonoInstaller, IInitializable
    {
        public override void InstallBindings()
        {
            Container.Bind<IRandomService>().To<RandomService>().AsSingle();
            Container.BindInterfacesAndSelfTo<ProjectInstaller>().FromInstance(this).AsSingle();
        }

        public void Initialize() =>
            SceneManager.LoadScene("Level");
    }
}