using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGoDown : MonoBehaviour
{
    [SerializeField] Rigidbody2D _wall;
    [SerializeField] float _wallSpeed;
    private void FixedUpdate()
    {
        _wall.AddForce(Vector2.down * _wallSpeed);
    }
    
}
