using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (globalController.getInstance().getCamerasActive())
        {
            foreach (Transform Child in transform)
            {
                if (Child.GetComponent<cameraScript>() != null)
                {
                    if (Child.GetComponent<cameraScript>().cameraID == globalController.getInstance().getTargetCamera())
                    {
                        Child.gameObject.SetActive(true);
                        //Debug.Log(globalController.getInstance().getTargetCamera());
                    }
                    else
                    {
                        Child.gameObject.SetActive(false);
                    }
                }
                if (Child.tag == "Floormap")
                {
                    Child.gameObject.SetActive(true);
                    foreach (Transform GrandChild in Child)
                    {
                        if (GrandChild.GetComponent<floorController>() != null)
                        {
                            if (GrandChild.GetComponent<floorController>().floorID == globalController.getInstance().getTargetFloor())
                            {
                                GrandChild.gameObject.SetActive(true);
                            }
                            else
                            {
                                GrandChild.gameObject.SetActive(false);
                            }
                        }
                    }
                }
                if (Child.tag == "FloorButtons")
                {
                    Child.gameObject.SetActive(true);
                }

            }
        }
        else if(globalController.getInstance().getCamerasActive() == false)
        {
            foreach (Transform Child in transform)
            {
                Child.gameObject.SetActive(false);
            }
        }
    }
}
