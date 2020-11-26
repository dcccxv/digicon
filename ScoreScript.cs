using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int Score = 0;
    public GameObject Re1;
    public GameObject Re2;
    public GameObject Re3;
    public GameObject Re4;
    public int Rnd = 0;

    public GameObject BigMonster;
    public GameObject SmallMonster;

    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "coin")
        {
            Score += 10;
            Destroy(col.gameObject);
            makeMonster();
        }
    }

    public void Reset() {
        Score = 0;
    }

    public void makeMonster()
    {
        if (Score % 200 == 0)
        {
            Rnd = Random.Range(0, 4);
            Instantiate(SmallMonster, new Vector3(objects[Rnd].transform.position.x, objects[Rnd].transform.position.y, objects[Rnd].transform.position.z), Quaternion.Euler(0f, 0f, 0f));
        }
        else if (Score % 50 == 0)
        {
            Rnd = Random.Range(0, 4);
            Instantiate(BigMonster, new Vector3(objects[Rnd].transform.position.x, objects[Rnd].transform.position.y, objects[Rnd].transform.position.z), Quaternion.Euler(0f, 0f, 0f));
        }
    }
}
