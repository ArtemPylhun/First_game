using System;
using Code.Runtime.Infrastructure.Services.Input;
using UnityEngine;
using Zenject;

namespace Code.Runtime.Gameplay.Logic
{
    public class Death : MonoBehaviour
    {
        [SerializeField] private Health _health;
        
        [SerializeField] private Rigidbody2D _rigidbody;
        
        [SerializeField] private Collider2D _collider;
        
        [SerializeField] private float _forceOnDeath;
  
        private IInputService _inputService;
        

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void OnValidate()
        {
            _health ??= GetComponent<Health>();
            _rigidbody ??= GetComponent<Rigidbody2D>();
            _collider ??= GetComponent<Collider2D>();
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
            _rigidbody.AddForce(Vector2.up * _forceOnDeath, ForceMode2D.Impulse);
            _collider.enabled = false;
        }
    }
}