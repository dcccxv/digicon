using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;

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
        if (col.gameObject.tag == "Plane")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            gameObject.tag = "Finish";
            Destroy(gameObject, 0.5f);
        }
    }
}
