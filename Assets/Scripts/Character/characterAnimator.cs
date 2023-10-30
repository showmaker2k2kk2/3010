using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnimator : MonoBehaviour
{
    public Transform target;

    public GameObject Enemy;

    public enum Animatortype { Movement,Attack };

    public enum Movementtype { Run,idle};
    public enum Attacktype { a,b,c};

    protected Animatortype currentAnimator;
    protected Movementtype currentMovetype;
    protected Attacktype  currentAttacktype;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMovement(Movementtype  type)
    {
        //if(currentAnimator==)
    }
}
