using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeLeftMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D _knifeLeft;
    [SerializeField] float _knifeMove=50f;
    
    void Update()
    {
        _knifeLeft.AddForce(Vector2.left * _knifeMove);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            transform.SetParent(collision.transform);

        }
        if (collision.gameObject.CompareTag("Fruit"))
        {
            transform.SetParent(collision.transform);
            
        }
    }
}
