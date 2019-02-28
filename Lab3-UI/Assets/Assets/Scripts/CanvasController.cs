using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    private Canvas canvas; 

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();        
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle the menue on and off.
        if (Input.GetKeyDown(KeyCode.M)) {
            canvas.enabled = !canvas.enabled;
        }
    }
}
