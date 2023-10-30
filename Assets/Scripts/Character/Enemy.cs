using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : Emity,ITakeDame
{
    protected int attackrange;

    public int Dame;
    public int currenthealth;
    public int maxHealth = 100;

    bool onflollow;


    public Transform Target => GameManager.Intance.player.transform;

    public Transform[] destinationwaypoint;
    private int curentpoint;
    Animator anim;

    private Action den_noi;
    bool arride;

    public float rangedesti = 0.1f;

    private Vector3 diretionToTarget => Target.position - transform.position;
    private bool InAttacRange => diretionToTarget.sqrMagnitude <= attackrange * attackrange;




    private void Awake()
    {
        anim = GetComponent<Animator>();
        den_noi = OnArride;
    }
    protected override void Start()
    {
        base.Start();
        currenthealth = maxHealth;
        curentpoint = 0;


        //Movewaypoint();

    }

    // Update is called once per frame
    void Update()
    {
        if (arride)
            return;
        if(Target !=null && InAttacRange)
        {
           
            agent.isStopped = true;
            return;
        }
        if (!InAttacRange)
        {

            setDestination2(Target.transform.position);
        }
        //if (!agent.pathPending && agent.remainingDistance < 0.1f)
        //{
        //Movewaypoint();

            //}

    }
    public void Takedame(int dame)
    {
        currenthealth -= dame;
        if(currenthealth<=0)
        {
            Death();
        }    
    }
    void Movewaypoint()
    {
        anim.SetBool("walk", true);
        agent.SetDestination(destinationwaypoint[curentpoint].position);

        curentpoint++;
        if (curentpoint >= destinationwaypoint.Length)
            curentpoint = 0;

    }

    void MoveTarget()
    {
        

        //if (player != null)
        //{

        //    transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        //}


    }
    public void OnArride()
    {
        arride = true;
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
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= rangedesti)
            den_noi?.Invoke();
    }
}
