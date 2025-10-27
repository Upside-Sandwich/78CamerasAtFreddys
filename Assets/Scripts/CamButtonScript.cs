using UnityEngine;

public class CamButtonScript : MonoBehaviour
{
    public int camSwitch;
    public bool isActive;
    public void SwitchCamera()
    {
        globalController.getInstance().setTargetCamera(camSwitch);
        Debug.Log("Switchted to camera " + camSwitch);
    }
    void Update()
    {
        if (globalController.getInstance().getTargetCamera() == camSwitch)
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }
    }
}
