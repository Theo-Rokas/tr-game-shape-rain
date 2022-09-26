using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundplayController : MonoBehaviour
{
    public static SoundplayController instance;

    [SerializeField]
    private AudioSource obtainSound, loseSound, buttonClick;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public float PlayButtonClick()
    {
        buttonClick.Play();
        float length = buttonClick.clip.length;
        return length;
    }

    public void PlayObtainSound()
    {
        obtainSound.Play();
    }

    public void PlayLoseSound()
    {
        loseSound.Play();
    }
}
