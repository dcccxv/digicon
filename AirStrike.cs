using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirStrike : MonoBehaviour
{
    public GameObject Bomb;
    public float xPosition = 0;
    public float zPosition = 0;
    public float interval = 3.0f;
    public int Running = 0;
    public int rndNumber;
    public GameObject[] objects;
    private int stage = 0;

    // Start is called before the first frame update
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Respawn");
        //InvokeRepeating("Strike", 1.0f, interval);
        //Strike();
    }

    void Update()
    {
        stage = GameObject.Find("Player").GetComponent<ImageView>().state;
    }
    // Update is called once per frame
    void Strike()
    {
        //if (Running == 1)
        {
            //xPosition = Random.Range(-14f, 14f);
            //zPosition = Random.Range(-14f, 14f);

            rndNumber = Random.Range(0, 6);
            
            for (int i = 0; i < objects.Length; i++)
            {
                rndNumber = Random.Range(0, 2);
                if (rndNumber == 1)
                {
                    Instantiate(Bomb, objects[i].transform.position, Quaternion.Euler(0f, 180f, 0f));
                }
            }
            /*if(rndNumber == 1)
            {
                for(int i = 0; i < 16; i += 2)
                {
                    Instantiate(Bomb, objects[i].transform.position, Quaternion.Euler(0f, 180f, 0f));
                }
            }
            else
            {
                for (int i = 1; i < 16; i += 2)
                {
                    Instantiate(Bomb, objects[i].transform.position, Quaternion.Euler(0f, 180f, 0f));
                }
            }*/
                //Instantiate(Bomb, new Vector3(xPosition, -177, zPosition), Quaternion.Euler(0f, 180f, 0f));

        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "End")
        {
            if (stage == 3)
                Strike();
        }
    }
}
