using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public Camera cam;
    public float m_moveSpeed;
    Vector3 lookDirection;
    public GameObject target;
    public GameObject targetL;
    public GameObject targetR;
    public GameObject targetB;
    public GameObject targetFR;
    public GameObject targetFL;
    public GameObject targetBR;
    public GameObject targetBL;

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {/*
        if (Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow))
        {*/
    /*
        float h = Input.GetAxis("Horizontal");
        if (h > 0)
        {
            transform.Translate(-Camera.main.transform.right);
        }
        else
        {
            transform.Translate(Camera.main.transform.right);
        }
        float v = Input.GetAxis("Vertical");
    */

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveHorizontal = Vector3.right * h;
        Vector3 moveVertical = Vector3.forward * v;
        //Vector3 velocity = (moveHorizontal + moveVertical).normalized;


        //Vector3 dir = cam.transform.localRotation * Vector3.forward;
        //transform.LookAt(transform.position + velocity);
        //transform.LookAt(target.transform.position);
        //transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);

        //transform.Translate(velocity * m_moveSpeed * Time.deltaTime, Space.World);

        if (v>0){
            if(h < 0){
                transform.LookAt(targetFL.transform.position);
            }else if (h > 0)
            {
                transform.LookAt(targetFR.transform.position);
            }
            else
            {
                transform.LookAt(target.transform.position);
            }
                //transform.Translate(Vector3.forward * m_moveSpeed * Time.deltaTime);
            //transform.LookAt(target.transform.position);
            transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
            transform.Translate(Vector3.forward * m_moveSpeed * Time.deltaTime);
        }
        if (v<0){
            if (h < 0)
            {
                transform.LookAt(targetBL.transform.position);
            }
            else if (h > 0)
            {
                transform.LookAt(targetBR.transform.position);
            }
            else
            {
                transform.LookAt(targetB.transform.position);
            }
            //transform.Translate(Vector3.back * m_moveSpeed * Time.deltaTime);
            //transform.LookAt(targetB.transform.position);
            transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
            transform.Translate(Vector3.forward * m_moveSpeed * Time.deltaTime);
        }
        if ( v == 0)
        {
            if (h < 0)
            {
                //transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
                //transform.LookAt(-target.transform.right);
                //transform.Translate(Vector3.forward * m_moveSpeed * Time.deltaTime);
                transform.LookAt(targetL.transform.position);
                transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
                transform.Translate(Vector3.forward * m_moveSpeed * Time.deltaTime);

                //transform.Translate(Vector3.left * m_moveSpeed * Time.deltaTime);
            }
            if (h > 0)
            {
                //transform.Translate(Vector3.right * m_moveSpeed * Time.deltaTime);
                transform.LookAt(targetR.transform.position);
                transform.localRotation = new Quaternion(0, transform.localRotation.y, 0, transform.localRotation.w);
                transform.Translate(Vector3.forward * m_moveSpeed * Time.deltaTime);
            }
        }
    }
}
