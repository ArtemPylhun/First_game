using System.Collections;
using Code.Runtime.Extensions;
using UnityEngine;

namespace Code.Runtime.Gameplay.Logic
{
    public class CollectablesSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnInterval = 2;
        [SerializeField] private GameObject _collectable;

        [SerializeField] private float _randomDeltaX = 2;
        public float RandomDeltaX => _randomDeltaX;

        private IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnInterval);
                SpawnEnemy();
            }
        }

        private void SpawnEnemy()
        {
            Instantiate(_collectable, transform.position.SetX(GetRandomX()), Quaternion.identity, gameObject.transform);
        }

        private float GetRandomX()
        {
            return Random.Range(-_randomDeltaX, _randomDeltaX);
        }
    }
}