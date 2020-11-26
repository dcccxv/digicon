using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SelectableObj")
        {
            Destroy(other.gameObject);
        }
    }
}
