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
            yield return new WaitForSeconds(2f);
        }
    }

    private void EnemyFireBullet()
    {
        EnemyBullet enemyBullet = Instantiate(bulletPrefab);
        enemyBullet.transform.position = transform.position;
        Rigidbody2D rbb = enemyBullet.GetComponent<Rigidbody2D>();
        rbb.velocity = Vector2.left * bulletSpeed;
    }
}
