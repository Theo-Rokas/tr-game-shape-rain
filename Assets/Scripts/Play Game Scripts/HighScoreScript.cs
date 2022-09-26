using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    [SerializeField]
    private Text highScoreText;

    void Start()
    {
        if(PlayerPrefs.GetInt("HighScore") != 0)
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }
}
