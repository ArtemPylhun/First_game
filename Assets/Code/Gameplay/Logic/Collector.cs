using Unity.VisualScripting;
using UnityEngine;

namespace Code.Gameplay.Logic
{
    internal sealed class Collector: MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out ICollectable collectable))
            {
                collectable.Collect();
            }
        }
    }
}