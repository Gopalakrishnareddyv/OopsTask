using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObject : MonoBehaviour
{

    // Start is called before the first frame update
    //create car instance

    //public Carclass car;

    //enum
    public enum Direction { north,sounth,east,west}
    void Start()
    {
        Direction mydirection;
        mydirection = reversedirection(Direction.east);
        Debug.Log("direction " + mydirection);
        //car.Drive();
        /*Carclass MyCar = new Carclass();
        Carclass MyCar1 = new Carclass("VOLVO");
        MyCar1.Drive();
        MyCar.CarName = "TATA";
        MyCar1.CarName = "KIA";
        MyCar.MadeYear = 2000;
        MyCar1.MadeYear = 1900;
        MyCar.MaxSpeed = 130.5f;
        MyCar1.MaxSpeed = 100.7f;
        MyCar.Drive();
        MyCar.Speed();
        //MyCar.ApplyBrakes();
        MyCar1.Drive();
        MyCar1.Speed();*/
    }
    Direction reversedirection(Direction direction)
    {
        Direction dir;
        dir = Direction.east;
        if (dir == Direction.east)
        {
            dir=Direction.west;
        }
        return dir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
