using UnityEngine;

public class PositionControl : MonoBehaviour
{
    public static Transform positionTransform;

    private Vector2 initialTouchPosition;

    void Update()
    {
        if (Input.touchCount == 1) // Changed to single touch for positioning
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                initialTouchPosition = touch.position - (Vector2)positionTransform.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Vector2 currentPosition = touch.position - initialTouchPosition;
                positionTransform.position = new Vector3(currentPosition.x, positionTransform.position.y, currentPosition.y);
            }
        }
    }
}
