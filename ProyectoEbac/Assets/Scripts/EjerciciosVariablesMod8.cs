using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{

    int variableEntera = 0;
    float variableFloat = 0;
    //public GameObject sphera;


    // Start is called before the first frame update
    void Start()
    {
        ejercicio2();
        ejercicio4();
        ejercicio5();
        ejercicio6();
        ejercicio1Parte2();
        ejercicio2Parte2();
        ejercicio3Parte2();
    }

    // Update is called once per frame
    void Update()
    {
        variableEntera++;
        //Debug.Log("Variable int incrementa cada frame " + variableEntera);
    }

    private void FixedUpdate()
    {
        variableFloat*=2;
        //Debug.Log("Variable float en FixedUpdate: " + variableEntera);

        //ejercicio 3 --
        if (variableEntera % 2 == 0)
            this.GetComponent<Renderer>().material.color = Color.red;
        else
            this.GetComponent<Renderer>().material.color = Color.green;

    }

    void ejercicio2()
    {
        float num1 = 6.7f;
        float num2 = 4.3f;
        int resultado = (int)(num1 + num2);
        Debug.Log("Resultado ejercicio 2: " + resultado);
    }

    void ejercicio4()
    {
        string color = "amarillo";
        switch (color)
        {
            case "rojo":
                this.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log("el color es rojo");
                break;
            case "azul":
                this.GetComponent<Renderer>().material.color = Color.blue;
                Debug.Log("el color es azul");
                break;
            case "amarillo":
                this.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.Log("el color es amarillo");
                break;
            default:
                this.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log("el color es por defecto");
                break;
        }
    }

    void ejercicio5()
    {
        float numero = 4.149592f;
        string str = numero.ToString("F4");
        Debug.Log("Número con 4 decimales: " + str);
    }

    void ejercicio6()
    {
        string nombreCompleto = "Carlos Alberto Orta";
        string nombre = nombreCompleto.Substring(0, 6);
        Debug.Log("Nombre: " + nombre + " " + nombreCompleto.Length);
        string segundoNombre = nombreCompleto.Substring(7, 7);
        Debug.Log("Segundo Nombre: " + segundoNombre);
        string apellido = nombreCompleto.Substring(15);
        Debug.Log("Apellido: " + apellido);
      
        string[] nombreLista = nombreCompleto.Split(' ');
        foreach (string partes in nombreLista)
        {
            Debug.Log("Mi nombre es: " + partes);
        }
    }

    void ejercicio1Parte2()
    {
        string numStr1 = "400";
        string numStr2 = "2";
        if (int.TryParse(numStr1, out int n1) && int.TryParse(numStr2, out int n2))
        {
            Debug.Log("Operación de multiplicar: " + (n1 * n2));
        }
        else
        {
            Debug.Log("Error al convertir los numeros");
        }
    }

    void ejercicio2Parte2()
    {
        string oracion = "Hola Mundo";
        string resultadoOracion = "";
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                resultadoOracion += oracion[i];
            }
        }
        Debug.Log("Caracteres que son par: " + resultadoOracion);
    }

    void ejercicio3Parte2()
    {
        string oracion = "Borro la palabra borro";
        string subOracion = oracion.Substring(5);
        Debug.Log("Quito los primeros 5 caracteres: " + subOracion);
    }


}
