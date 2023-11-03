using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform pointshoot;
    public GameObject paticle;
 
    Rigidbody rb;
    Animator anim;

    public float speed;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
       anim= GetComponent<Animator>();
  
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shoot();
          
            anim.SetBool("shotsigle", true);
          

        }
        else { anim.SetBool("shotsigle", false); }

    }
    void shoot()
    {
        GameObject obj = Instantiate(paticle, pointshoot.transform.position, transform.rotation);
        Rigidbody rbbu = obj.GetComponent<Rigidbody>();
        rbbu.AddForce(transform.forward * speed);
        Destroy(obj,4f);
    }    
}
