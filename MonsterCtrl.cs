using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MonsterCtrl : MonoBehaviour
{
    // 추적할 대상 Object
    private Transform playerTr;
    // 추적할 Object
    private Transform tr;
    // 추적 Object에 적용된 NavMeshAgent 컴포넌트
    private NavMeshAgent nvAgent;
    // Use this for initialization

    public GameObject Player;
    private float distance;

    private Animator ani;
    private bool Walk = false;
    private bool Attack = false;
    private bool Death = false;

    public float distanceMIN;
    public float distanceMax;


    void Start()
    {
        ani = GetComponent<Animator>();

        nvAgent = GetComponent<NavMeshAgent>();
        tr = GetComponent<Transform>();
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //추적 Object에 적용된 NavMeshAgent 컴포넌트에 추적대상 설정         
        //nvAgent.destination = playerTr.position;
    }
    // Update is called once per frame     
    void Update()
    {
        ani.SetBool("Walk", Walk);
        ani.SetBool("Attack", Attack);
        ani.SetBool("Death", Death);

        //nvAgent.destination = playerTr.position;
        //nvAgent.updateRotation = true;
        distance = Vector3.Distance(Player.transform.position, transform.position);
        

        
        if(distance < distanceMIN)
        {
            nvAgent.destination = playerTr.position;
            //distance = Vector3.Distance(Player.transform.position, transform.position);
            nvAgent.Resume();
            Walk = true;
        }
        if(distance > distanceMax)
        {
            nvAgent.Stop();
            Walk = false;
        }

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

        if (col.gameObject.tag == "Finish" || col.gameObject.tag == "Car")
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
