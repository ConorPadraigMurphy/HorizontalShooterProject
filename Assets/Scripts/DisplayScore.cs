using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI EndscoreText;
    void Start()
    {
        EndscoreText.text = "Enemies Destroyed: " + GameManager.Instance.score;
    }
}
