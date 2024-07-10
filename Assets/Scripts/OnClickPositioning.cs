using UnityEngine;

public class OnClickPositioning : MonoBehaviour
{
    void OnMouseDown()
    {
        PositionControl.positionTransform = this.transform;
    }
}
