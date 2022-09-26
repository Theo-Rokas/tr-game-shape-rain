using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShapes : MonoBehaviour
{
    public GameObject circle;
    public GameObject triangleUp;
    public GameObject triangleDown;
    public GameObject rectangleUp;
    public GameObject rectangleDown;

    public static float shapeSpawnTimer;
    private float currentShapeSpawnTimer;

    private float minX = -2f, maxX = 2f;

    void Start()
    {
        shapeSpawnTimer = 0.5f;
        currentShapeSpawnTimer = shapeSpawnTimer;
    }

    void Update()
    {
        Spawning();
    }

    void Spawning()
    {
        currentShapeSpawnTimer += Time.deltaTime;

        if(currentShapeSpawnTimer >= shapeSpawnTimer)
        {

            Vector3 temp = transform.position;
            temp.x = Random.Range(minX, maxX);

            GameObject newShape = null;

            int random = Random.Range(0, 5);

            if (random == 0)
                newShape = Instantiate(circle, temp, Quaternion.identity);
            else if (random == 1)
                newShape = Instantiate(triangleUp, temp, Quaternion.identity);
            else if (random == 2)
                newShape = Instantiate(triangleDown, temp, Quaternion.identity);
            else if (random == 3)
                newShape = Instantiate(rectangleUp, temp, Quaternion.identity);
            else if (random == 4)
                newShape = Instantiate(rectangleDown, temp, Quaternion.identity);

            if (newShape)
                newShape.transform.parent = transform;

            currentShapeSpawnTimer = 0f;
        }
    }
}
