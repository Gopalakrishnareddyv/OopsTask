using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
//This is Empty Carclass
public class Carclass
{
    //Creating Atrributes or properties
    public string CarName;
    public int MadeYear;
    public float MaxSpeed;

    //Constructor
    /*public Carclass()
    {
        Debug.Log("Default constructor");
    }
    public Carclass(string carname)
    {
        CarName = carname;
        //Debug.Log("Second constructor");
        Debug.Log("My new car name is " + CarName);

    }
    */
    //Behaviours or methods or functions
    public void Drive()
    {
        Debug.Log("This is to Drive a car and car name is "+CarName);
        Debug.Log("This is to Drive a car and car model is " +MadeYear );
        Debug.Log("This is to Drive a car and car speed is " + MaxSpeed);
    }
    public void ApplyBrakes()
    {
        Debug.Log("This is used to apply brakes");
    }
    /*public float Speed()
    {
        Debug.Log("The max speed of the car is "+MaxSpeed);
        return MaxSpeed;
    }*/
}
