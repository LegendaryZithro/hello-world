using UnityEngine;

/// <summary>
/// Keeps the camera positioned in an isometric angle while following the player.
/// Attach this script to the main camera.
/// </summary>
public class IsometricCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 20f, -20f);
    public float followSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);
        transform.LookAt(target);
    }
}
