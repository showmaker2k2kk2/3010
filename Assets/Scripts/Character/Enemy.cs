using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Emity,ITakeDame
{
    public int Dame;
    public int currenthealth;
    public int maxHealth = 100;

    public Transform[] destinationwaypoint;
    private int curentpoint;
    Animator anim;



    private void Awake()
    {
        anim = GetComponent<Animator>();    
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
        if (!agent.pathPending && agent.remainingDistance < 0.1f)
        {
        Movewaypoint();

           
        }

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
}
