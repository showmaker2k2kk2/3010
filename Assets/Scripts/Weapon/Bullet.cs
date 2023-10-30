using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Dame;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ITakeDame dame=other.GetComponent<ITakeDame>();
        dame?.Takedame(Dame);
        Debug.Log(other.name);     
    }
}
