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
        Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.Damagedealt(1);
            Destroy(gameObject);
        }
    }
}
