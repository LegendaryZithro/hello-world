using UnityEngine;

// Simple isometric camera that follows a target from a fixed angle
public class IsometricCamera : MonoBehaviour
{
    public Transform target; // Player or main object to follow
    public Vector3 offset = new Vector3(0, 10, -10); // offset for isometric view
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        // Desired position based on target with offset
        Vector3 desiredPosition = target.position + offset;
        // Smoothly move camera to the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        // Always look at the target
        transform.LookAt(target);
    }
}
