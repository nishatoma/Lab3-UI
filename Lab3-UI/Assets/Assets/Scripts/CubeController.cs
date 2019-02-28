using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{

    public GameObject panel;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 panelPos = Camera.main.WorldToScreenPoint(this.transform.position);
        // panelPos.y = panelPos.y + 150;
        // panel.transform.position = panelPos;
    }

    void FixedUpdate() {
        Vector3 panelPos = Camera.main.WorldToScreenPoint(this.transform.position);
        panelPos.y = panelPos.y + 150;
        panel.transform.position = panelPos;
    }

    void togglePanel() {
        Canvas canvas = GameObject.FindGameObjectWithTag("localCanvas").GetComponent<Canvas>();
        canvas.enabled = !canvas.enabled;
    }

    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            togglePanel();
        }
    }

    public void scaleCube() {
        float sliderScale = slider.value*10;
        this.transform.localScale = new Vector3(sliderScale, sliderScale, sliderScale);
        adjustScale();
    }

    void adjustScale() {
        if (this.transform.localScale.sqrMagnitude < 1) {
            this.transform.localScale = new Vector3(1,1,1);
        }
    }
}