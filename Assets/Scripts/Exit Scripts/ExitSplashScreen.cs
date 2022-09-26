using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSplashScreen : MonoBehaviour
{
    void Start()
    {
        Invoke("GoToMenu", 4f);
    }

    void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
