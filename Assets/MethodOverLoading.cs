using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodOverLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestPrint();
        TestPrint(1);
        //TestPrint(1.2f);
    }

    void TestPrint()
    {
        Debug.Log("Function without parameters");
    }
    void TestPrint(int i)
    {
        Debug.Log("function with int paramenetr " + i);
    }
    void TestPrint(float i)
    {
        Debug.Log("function with float paramenetr " + i);
    }
}
