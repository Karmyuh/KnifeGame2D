using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeRightMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D _knifeRight;
    [SerializeField] float _knifeMove = 50f;

    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        _knifeRight.AddForce(Vector2.right * _knifeMove);
    }
}
