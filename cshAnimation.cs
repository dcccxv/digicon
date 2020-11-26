using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshAnimation : MonoBehaviour
{
    private Animator ani;
    private float speed = 0.0f;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {


        if(Input.GetAxis("Horizontal")!=0 || Input.GetAxis("Vertical")!=0)
        {
            speed = 1.0f;
        }
        else
        {
            speed = 0.0f;
        }

        if (Input.GetMouseButton(0))
        {
            speed += 0.01f;
            if (speed > 1.0f) speed = 1.0f;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            speed = 0.0f;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            ani.SetBool("isWave", true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            ani.SetBool("isWave", false);
        }
        ani.SetFloat("Speed", speed);
    }

}
