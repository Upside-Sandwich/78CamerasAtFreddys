using Unity.VisualScripting;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public bool canLook = true;
    [Header("Rotation Settings")]
    public float rotationSpeed = 100f; // Degrees per second

    void Update()
    {
        if (canLook)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
        }
    }
    public void changeStatus(bool x)
    {
        canLook = x;
    }
}
