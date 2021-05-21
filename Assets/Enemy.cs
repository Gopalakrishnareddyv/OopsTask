using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//base class
public class Enemy:MonoBehaviour

{
    protected void Attack()//it can access only where it inherited class only
    {
        Debug.Log("Enemy attack");
        GetComponent<Renderer>().material.color = Color.green;
    }
}
