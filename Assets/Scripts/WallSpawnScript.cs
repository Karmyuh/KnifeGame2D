using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnScript : MonoBehaviour
{

    float _currentTime;
    [SerializeField] float spawntime;
    [SerializeField] GameObject _wall;
    [SerializeField] Transform _wallSpawner;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > spawntime)
        {
            SpawnStart();
        }
    }
    void SpawnStart()
    {
        Instantiate(_wall, _wallSpawner.position, _wallSpawner.rotation, _wallSpawner);
        ResetTimeFruit();
    }
    void ResetTimeFruit()
    {
        _currentTime = 0;
    }
}
