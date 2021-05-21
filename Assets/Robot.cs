using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Derived class
public class Robot : Enemy
{
    public bool IsAttacking = false;
    private void Update()
    {
        if (IsAttacking)
        {
            Attack();
            base.Attack();
        }

    }
    /*void Attack()
    {
        Debug.Log("This is Robot Attack Method");
    }*/
}
