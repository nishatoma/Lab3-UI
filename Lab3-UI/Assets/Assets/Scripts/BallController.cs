using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public Slider slider;
    Rigidbody rb;
    // Start is called before the first frame update
    float sliderGravity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sliderGravity = -(slider.value*100 + 9.81f);
    }

    // Update is called once per frame
    void Update()
    {
        sliderGravity = -((slider.value*100.0 + 9.81f) > 0.3 ? (slider.value*100 + 9.81f) : 9.81f);

        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5f) {
            toggleGravityAndKinematics(rb, true, false);
        } else {
            toggleGravityAndKinematics(rb, false, true);
        }
    }

    public void toggleGravity(Toggle toggle) {
        if (toggle.isOn) {
            rb.useGravity = true;
            rb.isKinematic = false;
        } else {
            rb.useGravity = false;
            rb.isKinematic = true;
        } 
    }

    public void setGravity() {
        // rb.AddForce(new Vector3(0, -slider.value*300, 0));
        Physics.gravity = new Vector3(0, (sliderGravity), 0);
    }

    public void updateGravityText(Text text) {
        text.text = "Gravity: " + Physics.gravity.y;
    }

    void toggleGravityAndKinematics(Rigidbody rb,bool gravity, bool kine) {
        rb.useGravity = gravity;
        rb.isKinematic = kine;
    }
}
