using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine("ColorTest");
        ColorsTest();
    }
    IEnumerator ColorTest()
    {
        print("Start of corotine");
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        yield return null;
        print("End of the corotine");
    }
    void ColorsTest()
    {
        print("Start of corotine");
        //yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.red;
        //yield return new WaitForSeconds(2.0f);
        GetComponent<Renderer>().material.color = Color.green;
        //yield return null;
        print("End of the corotine");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
