using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteShapes : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Circle" ||
            target.gameObject.tag == "RectangleDown" ||
            target.gameObject.tag == "RectangleUp" ||
            target.gameObject.tag == "TriangleDown" ||
            target.gameObject.tag == "TriangleUp")
            Destroy(target.gameObject);
    }
}
