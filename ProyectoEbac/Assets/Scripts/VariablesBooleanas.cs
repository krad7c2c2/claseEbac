using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{

    bool variable1;
    //bool variable2;
    //bool variable3;
    int valor1 = 5;

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        //variable2 = false;
        //variable3 = false;

        if (!variable1)
        {
            Debug.Log("esta variable es verdadera");
            Debug.Log("ya tiene el valor la variable 1");
        }

        if(valor1 <= 5)
        {
            Debug.Log("el valor de la variable es 5");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
