using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateShapes : MonoBehaviour
{
    [SerializeField]
    private Animator[] animators;

    private float shapeAnimateTimer;
    private float currentShapeAnimateTimer;

    void Start()
    {
        shapeAnimateTimer = 2f;
        currentShapeAnimateTimer = shapeAnimateTimer;
    }
       
    void Update()
    {
        RandomAnimation();
    }

    void RandomAnimation()
    {
        currentShapeAnimateTimer += Time.deltaTime;

        if(currentShapeAnimateTimer >= shapeAnimateTimer)
        {
            int random = Random.Range(0, 5);

            if (random == 0)
                animators[0].SetTrigger("CircleTrigger");
            else if (random == 1)
                animators[1].SetTrigger("RectangleDownTrigger");
            else if (random == 2)
                animators[2].SetTrigger("RectangleUpTrigger");
            else if (random == 3)
                animators[3].SetTrigger("TriangleDownTrigger");
            else if (random == 4)
                animators[4].SetTrigger("TriangleUpTrigger");

            currentShapeAnimateTimer = 0f;
        }
    }
}
