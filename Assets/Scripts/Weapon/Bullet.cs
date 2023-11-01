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



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Setspeed(float speed)
    {
        movespeed = speed;
    }    
    private void OnTriggerEnter(Collider objectother)
    {
        ITakeDame dame= objectother.GetComponent<ITakeDame>();
        dame?.Takedame(Dame);
        Debug.Log(objectother.name);
        hitFX.gameObject.SetActive(true);
        hitFX.Play();
    }
}
