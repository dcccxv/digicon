using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public float Speed;
    private int stage = 0;
    void Start()
    {
        
    }

    void Update()
    {
        //stage = GameObject.Find("Player").GetComponent<ImageView>().state;
        //if (stage >= 3)
        //{
            gameObject.transform.Translate(Vector3.left * Speed * Time.deltaTime, Space.World);
        //}

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "End")
        {
            gameObject.transform.position = new Vector3(884f, 520f, -252f);
        }
    }

}
