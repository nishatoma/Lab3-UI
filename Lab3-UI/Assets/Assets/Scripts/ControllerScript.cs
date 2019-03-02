using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;
    public Slider slider;
    public Slider slider2;
    public Slider slide3;
    public Slider slider4;
    // Start is called before the first frame update
    void Start()
    {
        // go = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate() {
         RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            if (hit.collider != null) {
                if (go == hit.collider.gameObject) {
                    // go = hit.transform.gameObject;
                    Debug.Log("Gotem");
                    if (OVRInput.GetDown(OVRInput.Button.One)) {
                        go.transform.SendMessage("OnVrEnter");
                    }
                    // Debug.DrawRay(transform.position, transform.forward, Color.green);
                    
                }

                if (go2 == hit.collider.gameObject) {
                    // go = hit.transform.gameObject;
                    Debug.Log("Gotem2");
                    if (OVRInput.GetDown(OVRInput.Button.One)) {
                        go2.transform.SendMessage("OnVrEnter");
                    }
                    // Debug.DrawRay(transform.position, transform.forward, Color.green);
                    
                }
                if (hit.collider.name == "Handle")
                {
                    Debug.Log("Hello LUUCA LUCA LUCA");
                    // Vector3 handleTrans = new Vector3(hit.point.x, hit.transform.position.y, hit.transform.position.z);
                    // hit.transform.position = handleTrans;
                    slider.value = (hit.point.x - 160) / 100;
                    Debug.Log(slider.value);
                } 
                if (hit.collider.name == "rotationHandle") {
                    slider2.value = (hit.point.x - 160) / 100;
                    Debug.Log(slider2.value);
                }

                if (hit.collider.name == "gg1")
                {
                    Debug.Log("Hello LUUCA LUCA LUCA");
                    // Vector3 handleTrans = new Vector3(hit.point.x, hit.transform.position.y, hit.transform.position.z);
                    // hit.transform.position = handleTrans;
                    slide3.value = (hit.point.x - 160) / 100;
                    Debug.Log(slider.value);
                } 
                if (hit.collider.name == "gg2") {
                    slider4.value = (hit.point.x - 160) / 100;
                    Debug.Log(slider2.value);
                }
            }
        } else {
            if (go != null) {
                go.transform.SendMessage("OnVrExit");
                // go = new GameObject();
            }
        }
    }

}
