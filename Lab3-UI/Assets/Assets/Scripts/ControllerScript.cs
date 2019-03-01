using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5f) {
            Physics.gravity = new Vector3(0, -50, 0);
        }
    }
}
