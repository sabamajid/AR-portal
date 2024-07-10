using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    void OnMouseDown()
    {
        // Assuming you have a script named RotateObject attached to this GameObject
        RotateObject.RotationTransform = this.transform;
    }
}