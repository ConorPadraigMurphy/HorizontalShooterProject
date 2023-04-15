using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.Instance.PlayPowerUpPickup();
            GameManager.Instance.ShieldPowerUp();
            Destroy(gameObject);
        }
    }
}
