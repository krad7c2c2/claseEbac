using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ejercicio1();
        ejercicio2();
        ejercicio3();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ejercicio1()
    {
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int[] arr3 = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arr1[i] = Random.Range(1, 10);
            arr2[i] = Random.Range(1, 10);
            arr3[i] = arr1[i] + arr2[i];
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Valor arreglo 1 en la posicion:  " + i + " es: " + arr1[i]);
            Debug.Log("Valor arreglo 2 en la posicion:  " + i + " es: " + arr2[i]);
            Debug.Log("Valor arreglo 3 en la posicion:  " + i + " es: " + arr3[i]);
        }
    }

    void ejercicio2()
    {
        string[] matrizPalabras = { "Mi", "ejercicio", "de", "concatenacion", "de", "palabras." };
        string oracion = "";

        foreach (string palabra in matrizPalabras)
        {
            oracion += palabra + " ";
        }

        Debug.Log("Oración concatenada: " + oracion);
    }

    void ejercicio3()
    {
        int[,] bidemincional = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[] unidimencional = { 1, 2 }; 
        int[] resultado = new int[3]; 

        for (int j = 0; j < 3; j++) // Columnas
        {
            resultado[j] = (bidemincional[0, j] * unidimencional[0]) + (bidemincional[1, j] * unidimencional[1]);
        }

        Debug.Log("Resultado de la multiplicación matriz * vector: " + string.Join(", ", resultado));
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Resultado de la multiplicación en la posicion:  " + i + " es: " + resultado[i]);
        }
    }


}
