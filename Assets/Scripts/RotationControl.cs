using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public static Transform RotationTransform;
    private float initialAngle;
    private Vector2 initialTouchPosition;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if (touch0.phase == TouchPhase.Began || touch1.phase == TouchPhase.Began)
            {
                initialTouchPosition = touch1.position - touch0.position;
                initialAngle = Mathf.Atan2(initialTouchPosition.y, initialTouchPosition.x) * Mathf.Rad2Deg;
            }
            else if (touch0.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
            {
                Vector2 currentTouchPosition = touch1.position - touch0.position;
                float currentAngle = Mathf.Atan2(currentTouchPosition.y, currentTouchPosition.x) * Mathf.Rad2Deg;
                float angleDifference = currentAngle - initialAngle;

                RotationTransform.Rotate(Vector3.up, angleDifference, Space.World);

                initialAngle = currentAngle;
            }
        }
    }
}
