using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] int bulletSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        // instantiate bullet
        Bullet bullet = Instantiate(bulletPrefab);
        // give it the same position as the player
        bullet.transform.position = transform.position;
        // give it velocity and move right
        Rigidbody2D rbb = bullet.GetComponent<Rigidbody2D>();
        //rbb.velocity = new Vector2(1 * speed, 0);
        rbb.velocity = Vector2.right * bulletSpeed;
    }

}
