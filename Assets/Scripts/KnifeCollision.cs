using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            
            transform.SetParent(collision.transform);
            Destroy(GetComponent<KnifeLeftMove>());
            Destroy(GetComponent<KnifeRightMove>());
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<BoxCollider2D>());

        }
        if (collision.gameObject.CompareTag("Fruit"))
        {
            transform.SetParent(collision.transform);
            Destroy(GetComponent<KnifeLeftMove>());
            Destroy(GetComponent<KnifeRightMove>());
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<BoxCollider2D>());
        }
    }
}
