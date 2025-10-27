using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public string CurrentState = "Office";
    public cameraController CameraController;
    globalController GlobalController;
    void Start()
    {
        GlobalController = globalController.getInstance();
    }

    public void ChangeState(string state)
    {
        CurrentState = state;
        TriggerState();
    }


    public void TriggerState()
    {
        if (CurrentState == "Office")
        {
            //Trigger office rotation functionality
            CameraController.changeStatus(true);
        }
        else if(CurrentState == "Cameras")
        {
            //Trigger Camera Functionality
        }
        else if(CurrentState == "Death")
        {
            //Trigger Cutscene and die
        }
        else
        {
            ChangeState("Office");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CurrentState == "Office")
        {
            globalController.getInstance().setCameraActive(true);
            CameraController.changeStatus(false);
            ChangeState("Cameras");
        }
        else if (Input.GetKeyDown(KeyCode.Space) && CurrentState == "Cameras")
        {
            globalController.getInstance().setCameraActive(false);
            CameraController.changeStatus(true);
            ChangeState("Office");
        }
    }
}
