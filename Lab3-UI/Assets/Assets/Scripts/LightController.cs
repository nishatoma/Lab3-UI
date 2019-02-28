using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] lights;
    public Slider slider;
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("lightP");
        initializeLights();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleLights(Toggle toggle) {
        foreach (GameObject light in lights) {
            if (toggle.isOn) {
                light.GetComponent<Light>().enabled = true;
            } else {
                light.GetComponent<Light>().enabled = false;
            }
            
        }
    }

    public void changeIntensity() {
        foreach (GameObject light in lights) {
            light.GetComponent<Light>().intensity = slider.value*10 + 1;
        }
    }

    void initializeLights() {
        foreach (GameObject light in lights) {
            light.GetComponent<Light>().enabled = false;            
        }
    }
}
