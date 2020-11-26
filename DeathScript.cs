using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject UI;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish" || col.gameObject.tag == "Monster")
        {
            Invoke("GameEnd", 1);
            
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Monster")
        {
            Invoke("GameEnd", 1);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Finish")
        {
            Invoke("GameEnd", 1);
        }
    }

    void GameEnd()
    {
        UI.SetActive(true);
        GameObject.Find("Player").transform.position = new Vector3(190, 360, -230);
        /*GameObject.Find("Main Camera").GetComponent<CoinScript>().Running=0;
        GameObject.Find("Main Camera").GetComponent<AirStrike>().Running = 0;

        GameObject[] objects = GameObject.FindGameObjectsWithTag("coin");
        for (int i = 0; i < objects.Length; i++)
            Destroy(objects[i]);

        GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Bomb");
        for (int i = 0; i < objects2.Length; i++)
            Destroy(objects2[i]);*/
    }
}
