using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform pointshoot;
    public GameObject aduu;
 
    Rigidbody rb;
    Animator anim;

    public float speed;


    private void Awake()
    {
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
        GameObject bullet = Instantiate(aduu, pointshoot.transform.position, transform.rotation);
        Rigidbody rigidbodyBulet= bullet.GetComponent<Rigidbody>();
        rigidbodyBulet.AddForce(transform.forward * speed, ForceMode.Impulse);
        Destroy(bullet, 1);
    }    
}
