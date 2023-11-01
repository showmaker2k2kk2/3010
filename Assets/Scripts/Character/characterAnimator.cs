using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class characterAnimator : MonoBehaviour
{

    #region
    //public enum Animatortype { Movement,Attack };

    //public enum Movementtype { Run,idle};
    //public enum Attacktype { NormalGun,GanttlingGun, grenade };//grenade  lựu đạn

    //protected Animator ator;
    //protected Animatortype currentAnimator;
    //protected Movementtype currentMovetype;
    //protected Attacktype  currentAttacktype;
    //protected string currentTrigger = "";
    #endregion
    public void Initialized()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #region /*Blentree*/
    //public Animator Ator
    //{
    //    get
    //    {
    //        if (ator == null)
    //            ator = GetComponent<Animator>();
    //        return ator;
    //    }
    //}
    //public void SetMovement(Movementtype  type)
    //{
    //    if (currentAnimator == Animatortype.Movement && currentMovetype == type)
    //        return;
    //    SetFloat("Movement", (int)type);
    //    SetTrigger("Move");
    //    currentAnimator = Animatortype.Movement;
    //    currentMovetype = type;
    //}

    //public void SetAttack(Attacktype type)
    //{
    //    if (currentAnimator == Animatortype.Attack && currentAttacktype == type)
    //        return;

    //    SetFloat("AttackType", (int)type);
    //    SetTrigger("Attack");

    //    currentAnimator = Animatortype.Attack;
    //    currentAttacktype = type;
    //}

    //public void SetTrigger(string param)
    //{
    //    if (param.Equals(currentTrigger))
    //        return;

    //    if (!String.IsNullOrEmpty(currentTrigger))
    //        Ator.ResetTrigger(currentTrigger);

    //    Ator.SetTrigger(param);
    //    currentTrigger = param;
    //}

    //public void SetBool(string param, bool value)
    //{
    //    Ator.SetBool(param, value);
    //}

    //public void SetFloat(string param, float value)
    //{
    //    Ator.SetFloat(param, value);
    //}
    #endregion

}
