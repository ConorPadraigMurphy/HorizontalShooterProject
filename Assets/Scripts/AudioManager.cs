using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource buttonClick;
    [SerializeField] private AudioSource enemyKill;
    [SerializeField] private AudioSource powerupPickup;
    [SerializeField] private AudioSource hurt;
    [SerializeField] private AudioSource playerGun;
    [SerializeField] private AudioSource MainmenuMusic;
    public static AudioManager Instance;
    public bool muted;
    public void Togglemute()
    {
        muted = !muted;
    }

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

    public void PlayButtonClick()
    {
        if (muted == false)
        {
            buttonClick.Play();
        }
    }

    public void PlayEnemyKill()
    {
        if (muted == false)
        {
            enemyKill.Play();
        }
    }

    public void PlayPowerUpPickup()
    {
        if (muted == false)
        {
            powerupPickup.Play();
        }
    }

    public void Hurt()
    {
        if (muted == false)
        {
            hurt.Play();
        }
    }

    public void PlayerGun()
    {
        if (muted == false)
        {
            playerGun.Play();
        }
    }
    public void MainMenu()
    {
        if (muted == false)
        {
            MainmenuMusic.Play();
        }
    }
}

