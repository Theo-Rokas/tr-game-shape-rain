using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // MainMenu
    public void PlayGame()
    {
        StartCoroutine(PlayGameDelay(SoundplayController.instance.PlayButtonClick()));
    }

    public void Credits()
    {
        StartCoroutine(CreditsDelay(SoundplayController.instance.PlayButtonClick()));
    }

    public void QuitGame()
    {
        StartCoroutine(QuitGameDelay(SoundplayController.instance.PlayButtonClick()));
    }

    // PlayGame
    public void PlayAgain()
    {
        StartCoroutine(PlayAgainDelay(SoundplayController.instance.PlayButtonClick()));
    }

    public void GoToMenu()
    {
        StartCoroutine(GoToMenuDelay(SoundplayController.instance.PlayButtonClick()));
    }

    IEnumerator PlayGameDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene("PlayGame");
    }

    IEnumerator CreditsDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene("Credits");
    }

    IEnumerator QuitGameDelay(float length)
    {
        yield return new WaitForSeconds(length);

        Application.Quit();
    }

    IEnumerator PlayAgainDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator GoToMenuDelay(float length)
    {
        yield return new WaitForSeconds(length);

        SceneManager.LoadScene("MainMenu");
    }
}
