using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraToActivate;

    [SerializeField]
    private GameObject cameraToDesactivate;

    private bool hasEntered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasEntered)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("EEEEEEEEEEEE");

                // Desactivate the actual camera and activate the new one
                cameraToActivate.SetActive(!cameraToActivate.activeSelf);
                cameraToDesactivate.SetActive(!cameraToDesactivate.activeSelf);
            }
        }
    }

    private void OnTriggerStay(Collider player)
    {
        Debug.Log("Trigger stay");
        hasEntered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
        hasEntered = false;
        // Desactivate the used camera and activate the previous one
        //cameraToActivate.SetActive(false);  
        //cameraToDesactivate.SetActive(true);
    }
}
