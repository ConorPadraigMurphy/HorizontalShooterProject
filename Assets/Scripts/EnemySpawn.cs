using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //[SerializeField] GameObject enemyPrefab;
    //public float interval = 0;
    private float counter = 0;
    private int enemyamount;
    bool isSpawning = true;
    [SerializeField] private int maxEnemies = 0;
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] GameObject[] enemyGroupPrefabs;

    // void Update()
    // {
    //     counter += Time.deltaTime;
    //     if (counter >= interval)
    //     {
    //         if (enemyamount < maxEnemies)
    //         {

    //             counter = 0;
    //         }
    //     }
    // }

    void Update()
    {

        StartCoroutine(SpawnEnemies());
        // if (enemyamount >= maxEnemies)
        // {
        //     isSpawning = false;
        // }

    }

    IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        while (isSpawning == true)
        {
            yield return wait;
            int randomenemy = Random.Range(0, enemyGroupPrefabs.Length);
            GameObject randomEnemyGroup = enemyGroupPrefabs[randomenemy];
            GameObject Enemyclone = Instantiate(randomEnemyGroup, transform.position, transform.rotation);
            enemyamount++;
            Debug.Log("Enemy amount: " + enemyamount);
        }
    }

    public void SpawnEnemy()
    {

    }
}
