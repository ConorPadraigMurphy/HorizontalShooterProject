using UnityEngine;

public class Bullet : MonoBehaviour
{
    EnemyHealth DoDamage;
    private Animator Animate;
    private void Start()
    {
        Destroy(gameObject, 1f);
        Animate = gameObject.GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "EnemyDefaultPlane")
        {
            DoDamage = collision.gameObject.GetComponent<EnemyHealth>();
            DoDamage.Damageenemy(1);
        }
    }
}
