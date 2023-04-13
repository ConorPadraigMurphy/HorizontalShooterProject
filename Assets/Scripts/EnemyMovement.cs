using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]Rigidbody2D rb;
    [SerializeField] float enemySpeed;

    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = Vector2.left * enemySpeed;
    }
}
