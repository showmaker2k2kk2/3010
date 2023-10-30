using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform pointshoot;
    public ParticleSystem bulet;
    Rigidbody rb;
    public float speed;


    private void Awake()
    {
       
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shoot();
        }    
    }
    void shoot()
    {
        ParticleSystem bullet = Instantiate(bulet, pointshoot.transform.position, transform.rotation);
       Rigidbody rigidbodyBulet= bullet.GetComponent<Rigidbody>();
        rigidbodyBulet.AddForce(transform.forward * speed, ForceMode.Impulse);
        Destroy(bullet, 1);
    }    
}
