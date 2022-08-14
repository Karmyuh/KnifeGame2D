using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeLeftMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D _knifeLeft;
    [SerializeField] float _knifeMove=50f;
    
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        _knifeLeft.AddForce(Vector2.left * _knifeMove);
    }
}
