using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public float waitTime = 2f;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("MainMenu");
    }
}
