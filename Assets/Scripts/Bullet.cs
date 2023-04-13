using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    EnemyHealth DoDamage;
    private void Start()
    {
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "EnemyDefaultPlane")
        {
            DoDamage = collision.gameObject.GetComponent<EnemyHealth>();
            DoDamage.Damageenemy(1);
        }
    }
}
