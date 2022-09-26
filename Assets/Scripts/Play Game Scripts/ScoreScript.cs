using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    void OnMouseDown()
    {
        if(ImageScript.icon == 0)
        {
            if (this.gameObject.tag == "Circle")
            {
                Destroy(this.gameObject);
                SoundplayController.instance.PlayObtainSound();
                GameplayController.instance.IncreaseScore();
            }
            else
            {
                SoundplayController.instance.PlayLoseSound();
                GameplayController.instance.StopGame();
            }            
        }

        if (ImageScript.icon == 1)
        {
            if (this.gameObject.tag == "RectangleDown")
            {
                Destroy(this.gameObject);
                SoundplayController.instance.PlayObtainSound();
                GameplayController.instance.IncreaseScore();
            }
            else
            {
                SoundplayController.instance.PlayLoseSound();
                GameplayController.instance.StopGame();
            }
        }

        if (ImageScript.icon == 2)
        {
            if (this.gameObject.tag == "RectangleUp")
            {
                Destroy(this.gameObject);
                SoundplayController.instance.PlayObtainSound();
                GameplayController.instance.IncreaseScore();
            }
            else
            {
                SoundplayController.instance.PlayLoseSound();
                GameplayController.instance.StopGame();
            }
        }

        if (ImageScript.icon == 3)
        {
            if (this.gameObject.tag == "TriangleDown")
            {
                Destroy(this.gameObject);
                SoundplayController.instance.PlayObtainSound();
                GameplayController.instance.IncreaseScore();
            }
            else
            {
                SoundplayController.instance.PlayLoseSound();
                GameplayController.instance.StopGame();
            }
        }

        if (ImageScript.icon == 4)
        {
            if (this.gameObject.tag == "TriangleUp")
            {
                Destroy(this.gameObject);
                SoundplayController.instance.PlayObtainSound();
                GameplayController.instance.IncreaseScore();
            }
            else
            {
                SoundplayController.instance.PlayLoseSound();
                GameplayController.instance.StopGame();
            }
        }
    }
}
