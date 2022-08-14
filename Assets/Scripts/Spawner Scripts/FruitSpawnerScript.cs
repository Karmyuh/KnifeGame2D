using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawnerScript : MonoBehaviour
{
        [Range(1, 5)] [SerializeField] float _minSpawnTime;
        [Range(2, 6)] [SerializeField] float _maxSpawnTime;
        float _randomSpawnTimeFruit, _currentTimeFruit;
        [SerializeField] GameObject[] _fruits;
        [SerializeField] Transform _FruitTra;

        private void Update()
        {
        _currentTimeFruit += Time.deltaTime;
            
            if (_currentTimeFruit > _randomSpawnTimeFruit)
            {
            FruitSpawnStart();

            }
            
        }
        void FruitSpawnStart()
        {
            int _randomIndex = Random.Range(0, _fruits.Length);
            Instantiate(_fruits[_randomIndex], _FruitTra.position, _FruitTra.rotation, _FruitTra);
        ResetTimeFruit();
        }
        void ResetTimeFruit()
        {
        _currentTimeFruit = 0;
        _randomSpawnTimeFruit = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
        
}
