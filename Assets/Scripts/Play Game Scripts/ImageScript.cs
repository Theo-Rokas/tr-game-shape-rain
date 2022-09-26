using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    [SerializeField]
    private Image image;

    [SerializeField]
    private Image[] images;

    public static int icon;
    public static bool stopRandomImage;

    public static float changeImageTimer;
    private float currentChangeImageTimer;

    void Start()
    {
        icon = 0;
        stopRandomImage = false;

        changeImageTimer = 2f;
        currentChangeImageTimer = changeImageTimer;
    }

    void Update()
    {
        RandomImage();
    }

    void RandomImage()
    {
        currentChangeImageTimer += Time.deltaTime;

        if (!stopRandomImage)
        {
            if(currentChangeImageTimer >= changeImageTimer)
            {
                int random = Random.Range(0, 5);

                if (random == 0)
                {
                    icon = 0;
                    image.sprite = images[0].sprite;
                }
                else if (random == 1)
                {
                    icon = 1;
                    image.sprite = images[1].sprite;
                }
                else if (random == 2)
                {
                    icon = 2;
                    image.sprite = images[2].sprite;
                }
                else if (random == 3)
                {
                    icon = 3;
                    image.sprite = images[3].sprite;
                }
                else if (random == 4)
                {
                    icon = 4;
                    image.sprite = images[4].sprite;
                }

                currentChangeImageTimer = 0f;
            }
        }
    }
}
