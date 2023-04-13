using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    EnemyHealth DoDamage;
    private void Start()
    {
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.Damagedealt(1);
        }
    }
}
