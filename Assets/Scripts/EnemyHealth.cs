using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 2;
    [SerializeField] int points;
    public void Damageenemy(int damage)
    {
        health -= damage;

        if (health == 0)
        {
            AudioManager.Instance.PlayEnemyKill();
            GameManager.Instance.updateScore(points);
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
