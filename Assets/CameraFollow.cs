using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // Reference to the player's transform
    public Vector3 offset;      // Offset distance between the player and camera
    public float smoothSpeed = 0.125f;  // Smoothing speed for camera movement

    void LateUpdate()
    {
        // Desired position of the camera
        Vector3 desiredPosition = player.position + offset;
        // Smoothly interpolate between the camera's current position and the desired position
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // Update the camera's position
        transform.position = desiredPosition;
    }
}
