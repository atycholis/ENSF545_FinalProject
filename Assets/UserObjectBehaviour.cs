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
        rb.mass = 0.0000001f;

        userObject.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);

    }

    // Update is called once per frame
    void Update()
    {
        scaleVal = transform.localScale.x;
        userObject.transform.localScale = new Vector3(scaleVal, scaleVal, scaleVal);

        rb.mass = scaleVal;

    }
}
