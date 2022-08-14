using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject _knife;
    [SerializeField] Rigidbody2D _knifeRb;
    [SerializeField] float _knifeSpeed;
    [SerializeField] Vector2 knifeForce;

    [SerializeField] Transform _knifeSpawner;

    //private bool isActive = true;
    private Rigidbody2D rb;
    private BoxCollider2D knifeCollider;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        knifeCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
       
    }


    public void KnifeMoveLeft()
    {

        rb.AddForce(knifeForce, ForceMode2D.Impulse);
        rb.gravityScale = 1;

    }

    public void KnifeMoveRight()
    {
        //Instantiate(_knife, _knifeSpawner, _knifeSpawner);
        _knifeRb.AddForce(Vector2.right * _knifeSpeed);
       
    }

   
}
