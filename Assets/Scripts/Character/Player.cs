using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Emity
{
    public float speed;
    private float ho;
    private float ve;

    public CanvasHealth canVasHealth;
    public int starthealth = 100;
    public int currentHealth;
  

    Rigidbody rb;
    Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        //animator.Initialized();

    }
    protected override void Start()
    {
        base.Start();
        currentHealth = starthealth;
        canVasHealth.setUpMaxHealth(currentHealth);
    }


    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        LookMouse();
        if (dir != Vector3.zero)
        {
            anim.SetBool("Run", true);
            //animator.SetMovement(characterAnimator.Movementtype.Run);

            MoveInput(dir);
        }
        else
        {
            //animator.SetMovement(characterAnimator.Movementtype.idle);
            anim.SetBool("Run", false);
        }    
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
           
        //}    
    }
    void MoveInput(Vector3 dirMove)
    {
        agent.Move(dirMove * speed * Time.deltaTime);
    }
   
        void LookMouse()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
  
}
