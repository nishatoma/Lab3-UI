using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GG : MonoBehaviour
{

    public GameObject panel;
    public Slider slider;
    public Canvas canvas;
    public Slider slider2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        // Vector3 panelPos = Camera.main.WorldToScreenPoint(this.transform.position);
        // panelPos.y = panelPos.y + 150;
        // panel.transform.position = panelPos;
        Vector3 panelPos = new Vector3(panel.transform.position.x, transform.position.y + 5, panel.transform.position.z);
        panel.transform.position = panelPos;

        scaleCube();
        adjustRotation();
    }

    void togglePanel() {
        canvas.enabled = !canvas.enabled;
    }

    void OnVrEnter() {
        togglePanel();
    }

    void OnVrExit() {
        Debug.Log("Exited");
    }

    public void scaleCube() {
        float sliderScale = slider.value*10;
        this.transform.localScale = new Vector3(sliderScale, sliderScale, sliderScale);
        adjustScale();
    }

    void adjustScale() {
        if (this.transform.localScale.sqrMagnitude < 1) {
            this.transform.localScale = new Vector3(1,1,1);
        } else if (this.transform.localScale.sqrMagnitude > 3) {
            this.transform.localScale = new Vector3(3, 3, 3);
        }
    }

    bool buttonTriggered() {
        return (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5f);
    }

    void adjustRotation() {
        float sliderScale = slider2.value*10;
        transform.rotation = Quaternion.Euler(sliderScale, sliderScale, sliderScale);
    }
}
