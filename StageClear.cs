using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject explosion;
    public GameObject Trigger;

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
        if (col.gameObject.tag == "Player")
        {
            Destroy(Wall1, 0);
            Instantiate(explosion, col.transform.position, col.transform.rotation);
            Destroy(Trigger, 0);
            Destroy(gameObject, 0.5f);
        }
    }
}
