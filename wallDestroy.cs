using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDestroy : MonoBehaviour
{
    private int stage = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stage = GameObject.Find("Player").GetComponent<ImageView>().state;
        if (stage == 4)
            Destroy(gameObject);
    }
}
