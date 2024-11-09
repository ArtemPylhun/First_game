using Code.Runtime.Infrastructure.Services.Input;
using UnityEngine;
using Zenject;

namespace Code.Runtime.Gameplay.Logic
{
    public class Death: MonoBehaviour
    {
        [SerializeField]
        private Health _health;
        private IInputService _inputService;

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }
        private void Awake()
        {
            _health.Death += OnDeath;
        }

        private void OnDestroy()
        {
            _health.Death -= OnDeath;
        }

        private void OnDeath()
        {
            _inputService.Disable();
        }
    }
}