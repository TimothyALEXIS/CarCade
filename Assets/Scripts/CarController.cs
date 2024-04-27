using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public Rigidbody theRB;
    public float forwardAccel=8f, reverseAccel=4f, maxSpeed=50f, turnStrength=180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = theRB.transform.position;
    }

    private void FixedUpdate()
    {
        theRB.AddForce(forwardAccel * transform.forward);
    }

}
