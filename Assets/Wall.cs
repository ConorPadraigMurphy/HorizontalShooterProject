using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyDefaultPlane")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PowerUp")
        {
            Destroy(collision.gameObject);
        }

    }
}
