using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 2;

    public void Damageenemy(int damage)
    {
        health -= damage;

        if (health == 0)
        {
            GameManager.Instance.updateScore(1);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (transform.position.x == -13)
        {
            Destroy(gameObject);
        }
    }
}
