using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{/*
    public Transform target; 
    public float dist = 7f;
    public float height = 5f;

    private Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    //Update is called once per frame
    void Update()
    {
        //카메라 위치 설정
        transform.position = target.position - (1 * Vector3.forward * dist) + (Vector3.up * height);
        transform.LookAt(target);
    }*/

    public Transform target;
    public float targetY;

    public float xRotMax;
    public float rotSpeed;
    public float scrollSpeed;

    public float distance;

    private float xRot;
    private float yRot;
    private Vector3 targetPos;
    private Vector3 dir;

    private void Update()
    {
        xRot += Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
        yRot += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;

        xRot = Mathf.Clamp(xRot, -xRotMax, xRotMax);

        targetPos = target.position + Vector3.up * targetY;

        dir = Quaternion.Euler(-xRot, yRot, 0f) * Vector3.forward;
        transform.position = targetPos + dir * -distance;
    }

    private void LateUpdate()
    {
        transform.LookAt(targetPos);
    }

}
