using UnityEngine;

public class globalController : MonoBehaviour
{
    private static globalController instance;
    bool camerasActive = false;
    private static int targetCamera;
    private static int targetFloor;
    void Start()
    {
        if (globalController.instance != null)
        {
            Object.Destroy(gameObject);
            return;
        }
        globalController.instance = this;
        globalController.instance.setTargetCamera(6);
        globalController.instance.setTargetFloor(1);
        Object.DontDestroyOnLoad(this);
    }
    public static globalController getInstance()
    {
        return globalController.instance;
    }
    public bool getCamerasActive()
    {
        return camerasActive;
    }
    public void setCameraActive(bool x)
    {
        camerasActive = x;
    }
    public int getTargetCamera()
    {
        return targetCamera;
    }
    public void setTargetCamera(int x)
    {
        targetCamera = x;
    }
    public int getTargetFloor()
    {
        return targetFloor;
    }
    public void setTargetFloor(int x)
    {
        targetFloor = x;
    }
    void Update()
    {
        
    }
}
