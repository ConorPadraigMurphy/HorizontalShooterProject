using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private EnemyBullet bulletPrefab;
    [SerializeField] int bulletSpeed = 10;

    void Start()
    {
        StartCoroutine(BurstTime());
    }

    IEnumerator BurstTime()
    {
        while (true)
        {
            EnemyFireBullet();
            yield return new WaitForSeconds(.5f);
            EnemyFireBullet();
            //makes the player invulnerable for a a second.
            yield return new WaitForSeconds(2f);
        }
    }

    private void EnemyFireBullet()
    {
        // instantiate bullet
        EnemyBullet enemyBullet = Instantiate(bulletPrefab);
        // give it the same position as the player
        enemyBullet.transform.position = transform.position;
        // give it velocity and move right
        Rigidbody2D rbb = enemyBullet.GetComponent<Rigidbody2D>();
        //rbb.velocity = new Vector2(1 * speed, 0);
        rbb.velocity = Vector2.left * bulletSpeed;
    }
}
