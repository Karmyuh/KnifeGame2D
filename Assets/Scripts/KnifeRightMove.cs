using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeRightMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D _knifeRight;
    [SerializeField] float _knifeMove = 50f;

    void Update()
    {
        _knifeRight.AddForce(Vector2.right * _knifeMove);
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
