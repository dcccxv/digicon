using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    public GameObject clear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Monster")
        {
            clear.SetActive(true);
            //clear.transform.position = new Vector3(clear.transform.position.x, -3.0f, clear.transform.position.z);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Monster")
        {
            clear.SetActive(false);
            //clear.transform.position = new Vector3(clear.transform.position.x, 100.0f, clear.transform.position.z);
        }
    }
}
