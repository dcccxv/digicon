using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public WheelCollider[] wheels = new WheelCollider[4];
    public Transform[] tires = new Transform[4]; 
    public float speed;
    public float angle;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0, 0, 0);
    }


    void Update()
    {
        Tire();

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(375, 343, -215);
        }
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = angle * Input.GetAxis("Horizontal");

        for (int i = 0; i < 4; i++)
        {
            wheels[i].motorTorque = speed * vertical;
        }

        for (int i = 0; i < 2; i++)
        {
            wheels[i].steerAngle = horizontal;
        }
    }

    void Tire()
    {
        for (int i = 0; i < 4; i++)
        {
            Quaternion quat;
            Vector3 pos;
            wheels[i].GetWorldPose(out pos, out quat);
            tires[i].position = pos;
            tires[i].rotation = quat;
        }
    }
}
