using System.Collections;
using Code.Extensions;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Gameplay.Logic
{
    public class CollectablesSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnInterval = 2;
        [SerializeField] private GameObject _collectable;

        [SerializeField] private int _randomDeltaX = 2;

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