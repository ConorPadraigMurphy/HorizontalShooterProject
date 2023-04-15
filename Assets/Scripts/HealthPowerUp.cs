using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.Instance.PlayPowerUpPickup();
            GameManager.Instance.health++;
            Destroy(gameObject);

            if (GameManager.Instance.health == 3)
            {
                Destroy(gameObject);
            }
        }
    }
}
