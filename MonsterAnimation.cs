using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimation : MonoBehaviour
{
    private Animator ani;
    private bool Walk = false;
    private bool Attack = false;
    private bool Death = false;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        ani.SetBool("Walk", Walk);
        ani.SetBool("Attack", Attack);
        ani.SetBool("Death", Death);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Walk = false;
            Attack = true;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Walk = false;
            Attack = true;
        }

        if (col.gameObject.tag == "Finish")
        {
            Death = true;
            Destroy(gameObject, 2);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Walk = true;
            Attack = false;
        }
    }
}
