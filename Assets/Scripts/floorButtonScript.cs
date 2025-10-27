using UnityEngine;

public class floorButtonScript : MonoBehaviour
{
    public int floorSwitch;
    public void Trigger()
    {
        globalController.getInstance().setTargetFloor(floorSwitch);
        Debug.Log("Switchted to floor " + floorSwitch);
    }
}
