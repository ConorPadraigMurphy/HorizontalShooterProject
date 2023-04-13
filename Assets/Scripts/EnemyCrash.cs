using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrash : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Doing Damage");
            GameManager.Instance.Damagedealt(1);
            Destroy(gameObject);
        }
    }
}
