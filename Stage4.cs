using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4 : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject explosion;

    public Transform Target;

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
            Destroy(Wall2, 0);
            Destroy(Wall3, 0);
            Destroy(Wall4, 0);

            //col.gameObject.SetActive(false);
            col.gameObject.GetComponent<ImageView>().enabled = false;
            col.gameObject.transform.position = new Vector3(1884f, 520f, -252f);

            GameObject obj = GameObject.FindWithTag("Car");
            obj.gameObject.GetComponent<CarMove>().enabled = true;
            obj.gameObject.GetComponent<ImageView5>().enabled = true;
            /*
            GameObject obj2 = GameObject.FindWithTag("SecondCamera");
            obj2.gameObject.SetActive(true);

            GameObject obj3 = GameObject.FindWithTag("MainCamera");
            obj3.gameObject.SetActive(false);*/

            GameObject obj2 = GameObject.FindWithTag("MainCamera");
            obj2.gameObject.GetComponent<CameraControl>().target = Target;

            Destroy(gameObject, 0.5f);
        }
    }
}
