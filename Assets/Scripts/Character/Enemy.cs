using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : Emity,ITakeDame
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




    private void Awake()
    {
        anim =GetComponentInChildren<Animator>();
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

        //isMoving = agent.velocity.magnitude >0;
        //if (isMoving) 
        // {

        // anim.SetBool("walk", true);
        // }
        //else
        // {
        //     anim.SetBool("walk", false);
        // }
        //Movewaypoint();
        //if (arride)
        //    return;
        //if (Target != null && InAttacRange)
        //{

        //    agent.isStopped = true;
        //    return;
        //}
        //if (!InAttacRange)
        //{

        //    setDestination2(Target.transform.position);
        //}
        //else
        //{

        //}    
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
            Movewaypoint();
            //if(animMove)
            //{
            //anim.SetBool("walk", true);
            //}    


            //    //animator.SetMovement(characterAnimator.Movementtype.Run);
            //    //agent.SetDestination(destinationwaypoint[curentpoint].position);

               }
            //MoveTarget();

            //anim.SetTrigger("dibo");
          

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

        setDestination2(destinationwaypoint[curentpoint].position);
        anim.SetTrigger("dibo");


        //curentpoint++;
        //if (curentpoint >= destinationwaypoint.Length)
        //    curentpoint = 0;

    }

    void MoveTarget()
    {


        if (player != null)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

           anim.SetBool("walk", true);
        }


    }
    public void OnArride()
    {
        arride = true;
        this.DelayCall(6, () =>
        {
            curentpoint++;
            if (curentpoint >= destinationwaypoint.Length)
                curentpoint = 0;
            arride = false;
        });
        anim.SetBool("walk", false);
    }
    public void setDestination2(Vector3 destination)
    {
        agent.isStopped = false;
        agent.SetDestination(destination);
        if (Vector3.Distance(transform.position, destination) <= AgentBody.radius)
        {
            OnArride();
        }   
    }
}
