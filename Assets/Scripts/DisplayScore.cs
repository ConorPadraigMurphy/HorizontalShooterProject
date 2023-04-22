using UnityEngine;
using TMPro;


public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI EndscoreText;
    void Start()
    {
        EndscoreText.text = "Score: " + GameManager.Instance.score;
    }
}
