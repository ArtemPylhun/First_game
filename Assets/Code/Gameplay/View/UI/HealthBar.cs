using Code.Gameplay.Logic;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.View.UI
{
    internal class HealthBar : MonoBehaviour
    {
        [SerializeField] 
        private Image _image;

        [SerializeField] 
        private Health health;
        private void Update()
        {
            _image.fillAmount = health.CurrentHealth / health.MaxHealth;
        }
    }
}