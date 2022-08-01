using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    
     float _currentTime;
    [SerializeField] float spawntime;
    [SerializeField] GameObject _background;
    [SerializeField] Transform _backgroundSpawner;

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
        Instantiate(_background, _backgroundSpawner.position, _backgroundSpawner.rotation, _backgroundSpawner);
        ResetTimeFruit();
    }
    void ResetTimeFruit()
    {
        _currentTime = 0;
    }
}
