using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private int enemyamount;
    bool isSpawning = true;
    [SerializeField]  int maxEnemies = 1;
    [SerializeField]  float spawnRate = 2f;
    [SerializeField] GameObject[] enemyGroupPrefabs;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (isSpawning == true)
        {
            yield return wait;
            int randomenemy = Random.Range(0, enemyGroupPrefabs.Length);
            GameObject randomEnemyGroup = enemyGroupPrefabs[randomenemy];
            Instantiate(randomEnemyGroup, transform.position, transform.rotation);
            enemyamount++;
            Debug.Log("Enemy amount: " + enemyamount);
            if (enemyamount >= maxEnemies)
            {
                isSpawning = false;
            }
        }
    }
}
