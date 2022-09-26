using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotate : MonoBehaviour
{
    private float RotateSpeed = 1.2f;
        
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
