using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject _knife;
    [SerializeField] Rigidbody2D _knifeRb;
    [SerializeField] float _knifeSpeed;

    [SerializeField] Transform _knifeSpawner;
    

    public void KnifeMoveLeft()
    {
        //Instantiate(_knife, _knifeSpawner, _knifeSpawner);
        _knifeRb.AddForce(Vector2.left*_knifeSpeed);
        
    }

    public void KnifeMoveRight()
    {
        //Instantiate(_knife, _knifeSpawner, _knifeSpawner);
        _knifeRb.AddForce(Vector2.right * _knifeSpeed);
       
    }

   
}
