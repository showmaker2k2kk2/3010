using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : Emity, ITakeDame
{

    protected int attackrange;
    public int Dame;
    public int currenthealth;
    public int maxHealth = 100;
    public NavMeshAgent AgentBody => this.TryGetMonoComponent(ref agent);


    bool animMove;

    public Transform player;
    public float speed;

    public Transform Target => GameManager.Intance.player.transform;
    public Transform[] destinationwaypoint;
    private int curentpoint;
    Animator anim;

    private Action den_noi;
    bool arride;

    public float rangedesti = 0.1f;

    private Vector3 diretionToTarget => Target.position - transform.position;
    private bool InAttacRange => diretionToTarget.sqrMagnitude <= attackrange * attackrange;
    bool isdeath = false;




    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        den_noi = OnArride;
    }
    protected override void Start()
    {
        base.Start();
        currenthealth = maxHealth;
        curentpoint = 0;


        //Movewaypoint();

    }

    bool isMoving;
    void Update()
    {
        if (isdeath)
            return;

        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            Movewaypoint();

        }
    }
    public void Takedame(int dame)
    {
        currenthealth -= dame;
        if (currenthealth <= 0)
        {
            Death();
        }
    }
    void Movewaypoint()
    {
        isdeath = false;
        setDestination2(destinationwaypoint[curentpoint].position);

    }


    public void OnArride()
    {
        arride = true;
        anim.SetBool("walk", false);
        this.DelayCall(2, () =>
        {
            curentpoint++;
            if (curentpoint >= destinationwaypoint.Length)
                curentpoint = 0;
            arride = false;
        });
    }

    public void setDestination2(Vector3 destination)
    {
        agent.isStopped = false;
        anim.SetBool("walk", true);
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= AgentBody.radius)
        {
            OnArride();
        }
    }
    protected override void Death()
    {
        isdeath = true;
        anim.SetTrigger("Dead");
        anim.SetBool("walk", false);
        agent.isStopped = true;


    }
}