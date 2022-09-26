using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private GameObject helpText;

    [SerializeField]
    private GameObject panel;

    [SerializeField]
    private GameObject shapeSpawner;

    private int score;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        if ((score % 5) == 0) 
            if(ImageScript.changeImageTimer > 1f)
                ImageScript.changeImageTimer -= 0.05f;
    }

    public void StopGame()
    {
        ImageScript.icon = 0;
        ImageScript.stopRandomImage = true;

        shapeSpawner.SetActive(false);
        helpText.SetActive(false);
        panel.SetActive(true);

        if(score > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", score);
    }
}
