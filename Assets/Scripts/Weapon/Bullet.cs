using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Dame;
    public float movespeed = 100;


    [Header("Configuration")]
    public float moveSpeed = 100f;
    public float destroyAffterTime = 5f;

    [Header("Object Reference")]
    public ParticleSystem projectileFX = null;
    public ParticleSystem hitFX = null;
    public ParticleSystem flashFx = null;

    Rigidbody rb;
    private void Awake()
    {
        rb= GetComponent<Rigidbody>();
    }

    void Start()
    {
        projectileFX.Play();
    }

    // Update is called once per frame  
    void Update()
    {
      
    }
    public void Setspeed(float speed)
    {

        movespeed = speed;
    } 
    public void Active()
    {
        projectileFX.Play();
 
    }
    public void active2()
    { flashFx.Play(); }
    private void OnTriggerEnter(Collider objectother)
    {
        ITakeDame dame= objectother.GetComponent<ITakeDame>();
        dame?.Takedame(Dame);
        Debug.Log(objectother.name);
        hitFX.gameObject.SetActive(true);
        hitFX.Play();
    }
public void Movebu()
    {
        rb.AddForce(transform.forward * moveSpeed);
    }
}
