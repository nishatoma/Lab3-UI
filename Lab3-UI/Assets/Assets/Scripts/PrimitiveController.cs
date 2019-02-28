using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimitiveController : MonoBehaviour
{
    public GameObject primitive;
    public Toggle toggle;
    Rigidbody rb;
    Vector3 pos;
    // Array of primitive rigid bodies
    List<Rigidbody> primitives;
    // Was the G key pressed?
    bool isGLetterPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        primitives = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.O)) {
            primitive = Instantiate(primitive, getPosition(), Quaternion.identity);
            rb = primitive.GetComponent<Rigidbody>();
            primitives.Add(rb);
        } else if (Input.GetKeyDown(KeyCode.G)) {
            isGLetterPressed = !isGLetterPressed;
            toggleGravity();
        } else if (Input.GetKeyDown(KeyCode.F)) {
            applyImpulseForce();
        }
    }

    public void toggleGravity(Toggle toggle) {
        foreach(Rigidbody rb in primitives) {
            if (toggle.isOn) {
                rb.useGravity = true;
                rb.isKinematic = false;
            } else {
                rb.useGravity = false;
                rb.isKinematic = true;
            } 
        }
        
    }

    void toggleGravity() {
        foreach(Rigidbody rb in primitives) {
            if (isGLetterPressed) {
                rb.useGravity = true;
                rb.isKinematic = false;
            } else {
                rb.useGravity = false;
                rb.isKinematic = true;
            } 
        }
        
    }

    Vector3 getPosition() {
        float x = Random.Range(195, 210);
        float y = Random.Range(6, 10);
        float z = Random.Range(148, 158);
        pos = new Vector3(x, y, z);
        return pos;
    }

    void applyImpulseForce() {
        float x;
        float y;
        float z;
        Vector3 force;
        // Iterate over all primitives.
        foreach(Rigidbody rb in primitives) {
            // Generate a random force for each rigid body
            x = Random.Range(-20, 20);
            y = Random.Range(-20, 20)*Physics.gravity.y;
            z = Random.Range(-20, 20);
            force = new Vector3(x, y, z);
            // Set kinematic to false so the objects can move
            rb.isKinematic = false;
            // Add force.
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
