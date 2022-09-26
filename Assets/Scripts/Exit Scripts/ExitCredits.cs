using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCredits : MonoBehaviour
{
    void Start()
    {
        Invoke("GoToMenu", 8f);
    }

    void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
