using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    bool isToggleOn = false;
    public Slider slider;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0, rb.mass*Time.deltaTime, 0));
    }

    public void toggleGravity() {
        rb.useGravity = !isToggleOn;
        // isToggleOn = !isToggleOn;
    }

    public void setMass() {
        rb.mass = slider.value*500;
        rb.useGravity = !isToggleOn;
        rb.AddForce(new Vector3(0, -rb.mass*Time.deltaTime, 0));
    }
}
