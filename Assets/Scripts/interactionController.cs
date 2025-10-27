using UnityEngine;

public class interactionController : MonoBehaviour
{
    [Header("Raycast Settings")]
    public Camera playerCamera; // Assign your camera in the inspector
    public float rayDistance = 100f;
    public LayerMask interactableLayers; // Optional: filter what can be hit

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left-click
        {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance, interactableLayers))
            {
                Debug.Log("Hit object: " + hit.collider.name);

                // Example: call a method on the hit object
                hit.collider.gameObject.GetComponent<interactFunction>().InteractCall(); 
            }
        }
    }
}
