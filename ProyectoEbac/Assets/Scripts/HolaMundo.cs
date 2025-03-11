using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        //print("esto solo es un print");
      
        //Debug.LogError("Hola MUndo");
        //Debug.LogWarning("Algo va mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log("Que onda " + x);

        Debug.Log("Hola desde update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Holad desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El Objeto a sido habilidato");
    }

    private void OnDisable()
    {
        Debug.Log("El objeto a sido deshabilitado");
    }
}
