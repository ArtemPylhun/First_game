using System;
using UnityEngine;

namespace Code.Runtime.Gameplay.Logic
{
    public class Health: MonoBehaviour
    {
        [SerializeField]
        private float _currentHealth;
        public float CurrentHealth => _currentHealth;   
        public float MaxHealth { get; private set; }

        public event Action HealthChanged;
        
        private void Start()
        {
            MaxHealth = _currentHealth;
        }

        public void Subtract(float healthToSubtract)
        {
            if (healthToSubtract < 0)
                throw new InvalidOperationException($"Health to subtract must be positive, but was {healthToSubtract}");
            
            _currentHealth -= healthToSubtract;
            
            if (_currentHealth < 0)
            {
                _currentHealth = 0;
            }
        }
    }
}