using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform pointshoot;
    
    public Bullet bulet;
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
            bulet.flashFx.Play();

        }
        else { anim.SetBool("shotsigle", false); }

    }
    void shoot()
    {
        GameObject obj = Instantiate(paticle, pointshoot.transform.position, transform.rotation);
        Bullet bullet = obj.GetComponent<Bullet>();
        bullet.Movebu();


        //bu.Setspeed(100);
        //Rigidob.AddForce(transform.forward * speed, ForceMode.Impulse);
        


        //bullet.Setspeed(100);
        Destroy(obj,4f);
    }    
}
