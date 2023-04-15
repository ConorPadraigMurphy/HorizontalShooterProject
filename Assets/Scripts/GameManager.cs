using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{


    public static GameManager Instance;
    public GameObject EnemySpawn;
    public GameObject canvas;
    public int health;
    public int maxHealth;
    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;
    public int score;
    private bool invulnerability = false;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        score = 0;
        updateScore(0);
        Scene scene = SceneManager.GetActiveScene();

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            AudioManager.Instance.MainMenu();
        }
    }

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (SceneManager.GetActiveScene().name == "Level1" || SceneManager.GetActiveScene().name == "Level2"
            || SceneManager.GetActiveScene().name == "Level3" || SceneManager.GetActiveScene().name == "EndlessLevel")
            {
                canvas.SetActive(true);
            }
            else
            {
                canvas.SetActive(false);
            }

            if (SceneManager.GetActiveScene().name == "MainMenu")
            {
                health = 3;
                score = 0;
                scoreText.text = "Score: " + score;
            }
        }


    }

    void FixedUpdate()
    {
        int enemiesLeft = FindObjectsOfType<EnemyHealth>().Length;

        if (SceneManager.GetActiveScene().name == "Level1" && enemiesLeft == 0)
        {
            SceneManager.LoadSceneAsync("AfterLevel");
        }
        if (SceneManager.GetActiveScene().name == "Level2" && enemiesLeft == 0)
        {
            SceneManager.LoadSceneAsync("AfterLevel");
        }
        if (SceneManager.GetActiveScene().name == "Level3" && enemiesLeft == 0)
        {
            SceneManager.LoadSceneAsync("AfterLevel");
        }
        if (SceneManager.GetActiveScene().name == "Level3" && health == 0)
        {
            SceneManager.LoadSceneAsync("AfterEndlessLevel");
        }


    }
    public void Damagedealt(int damage)
    {
        //Only if the player is not invulnerable will they take damage to prevent taking more than one damage if you collid into the enemy multiple times very quickly
        if (!invulnerability)
        {
            //AudioManager.Instance.Hurt();
            health -= damage;
            StartCoroutine(DamageCooldown());
        }
        //If the players health is less than or equal to zero reset the palyers stats
        if (health <= 0)
        {
            health = 3;
            score = 0;
            scoreText.text = "Score: " + score;
            SceneManager.LoadSceneAsync("DeathScreen");
        }
    }

    public IEnumerator DamageCooldown()
    {
        //makes the player invulnerable for a a second.
        invulnerability = true;
        yield return new WaitForSeconds(1f);
        invulnerability = false;
    }

    public IEnumerator ShieldPowerUp()
    {
        //makes the player invulnerable for a a second.
        invulnerability = true;
        yield return new WaitForSeconds(4f);
        invulnerability = false;
    }

    public void updateScore(int scoreToAdd)
    {
        //Updates the score UI for the player
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        Debug.Log(score);

    }
}
