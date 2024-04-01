/*using System.Diagnostics;
using UnityEngine;

public class TextAboveTarget : MonoBehaviour
{
    public Transform imageTarget; // Assign your image target object in the inspector
    public float heightAboveTarget = 0.5f; // Adjust this to change how high above the target the text appears

    void Update()
    {
        if (imageTarget == null)
        {
            System.Diagnostics.Debug.LogError("Image target is not assigned to TextAboveTarget script.");
            return;
        }

        // Position the text just above the image target
        Vector3 targetPosition = imageTarget.position + new Vector3(0, heightAboveTarget, 0);
        transform.position = targetPosition;

        // Rotate the text to always face the camera
        // This assumes the main camera is the AR camera
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
    }
}
*/