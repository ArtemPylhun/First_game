using UnityEngine;

namespace Code.Gameplay.Logic
{
    public class Mace : MonoBehaviour, ICollectable
    {
        [SerializeField]
        private float _healthToSubstract = 10;

        public void Collect(Collector collector)
        {
            collector.GetComponent<Health>().Subtract(_healthToSubstract);
        }
    }
}