using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        /*
        GameObject.Find("Player").GetComponent<ScoreScript>().Reset();

        GameObject[] objects = GameObject.FindGameObjectsWithTag("coin");
        for (int i = 0; i < objects.Length; i++)
            Destroy(objects[i]);

        GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Monster");
        for (int i = 0; i < objects2.Length; i++)
            Destroy(objects2[i]);

        GameObject[] objects3 = GameObject.FindGameObjectsWithTag("Bomb");
        for (int i = 0; i < objects3.Length; i++)
            Destroy(objects3[i]);

        GameObject.Find("Player").transform.position = new Vector3(2, 4, -10);
        GameObject.Find("Plane").transform.position = new Vector3(9, 15, -40);

        GameObject.Find("Main Camera").GetComponent<CoinScript>().Running = 1;
        GameObject.Find("Main Camera").GetComponent<AirStrike>().Running = 1;*/
        GameObject.Find("Final").GetComponent<Finish>().count++;
        //GameObject.Find("Player").transform.position = new Vector3(190, 360, -230);
        UI.SetActive(false);
    }
}
