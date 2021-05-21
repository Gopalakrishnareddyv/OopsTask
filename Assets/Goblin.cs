using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Derived class
public class Goblin : MonoBehaviour
{
    private void Start()
    {
        Goblin myGoblin = new Goblin();
        myGoblin.Attack();

        Goblin myRedGoblin = new RedGoblin();
        myRedGoblin.Attack();

        Goblin myGreenGoblin = new GreenGoblin();
        myGreenGoblin.Attack();
    }
    public  virtual void Attack()
    {
        Debug.Log("Goblin");
    }
}
public class RedGoblin : Goblin
{
    public override void Attack()
    {
        Debug.Log("RedGoblin");
    }
}
public class GreenGoblin : Goblin
{
    public override void Attack()
    {
        Debug.Log("GrrenGoblin");
    }
}