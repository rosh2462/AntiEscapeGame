using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomscript : MonoBehaviour
{
    private float zoom;
    private float zoomMultiplier = 4f;
    private float minZoom = 2f;
    private float maxZoom = 8f;
    private float velocity = 0f;
    private float smoothTime = 0.25f;

    [SerializeField] private Camera cam;

    private void Start()
    {
        zoom = cam.orthographicSize;
    }

    private void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse click position in world coordinates
            Vector3 mouseClickPosition = cam.ScreenToWorldPoint(Input.mousePosition);

            // Zoom to the clicked position
            ZoomToPosition(mouseClickPosition);
        }

        // Handle mouse scroll for zooming
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);
    }

    private void ZoomToPosition(Vector3 targetPosition)
    {
        // Set the target zoom level
        float targetZoom = maxZoom; // You can adjust this value based on your preference

        // Smoothly zoom to the target position
        zoom = Mathf.SmoothDamp(cam.orthographicSize, targetZoom, ref velocity, smoothTime);

        // Set the camera position to center on the clicked position
        cam.transform.position = new Vector3(targetPosition.x, targetPosition.y, cam.transform.position.z);
    }
}
