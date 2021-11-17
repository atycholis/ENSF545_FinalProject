using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserObjectBehaviour : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject userObject;

    private float scaleVal = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 0.1f;

        userObject.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);

    }

    // Update is called once per frame
    void Update()
    {
        scaleVal = transform.localScale.x;

        // If the user presses the left mouse button when hovering over the object, double its size and weight 
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                scaleVal = scaleVal + 0.1f;
                userObject.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);
                rb.mass = scaleVal;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                scaleVal = scaleVal - 0.1f;
                userObject.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);
                rb.mass = scaleVal;
            }
        }

    }
}
