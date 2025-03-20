using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ejercicion1
        List<int> lista = ejercicio1(10, 1, 100);

        // Ejercicio2
        int[] arreglo = { 5, 8, 1, 3, 9, 4 };
        ejercicio2(arreglo);

        // Ejercicio3
        List<string> listaConDuplicados = new List<string> { "gato", "perro", "gato", "pato", "leon" };
        ejercicio3(listaConDuplicados);

        // Ejercicio4
        Stack<string> pila = new Stack<string>();
        pila.Push("Uno");
        pila.Push("Dos");
        pila.Push("Tres");
        Ejercicio4(pila);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 1
    public List<int> ejercicio1(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> listaAleatoria = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numeroAleatorio = UnityEngine.Random.Range(rangoInferior, rangoSuperior);
            listaAleatoria.Add(numeroAleatorio);
        }
        Debug.Log("Lista aleatoria: " + string.Join(", ", listaAleatoria));
        return listaAleatoria;
    }

    // 2
    public int[] ejercicio2(int[] arreglo)
    {
        Array.Sort(arreglo);
        Array.Reverse(arreglo);

        Debug.Log("Ordena Arreglo: " + string.Join(", ", arreglo));
        return arreglo;
    }

    // 3
    public HashSet<T> ejercicio3<T>(List<T> lista)
    {
        HashSet<T> sinDuplicados = new HashSet<T>(lista);

        Debug.Log("Elimina duplicados: " + string.Join(", ", sinDuplicados));
        return sinDuplicados;
    }

    // 4
    public void Ejercicio4(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();
    
        Debug.Log("Contenido de la pila:");
        foreach (var item in pila)
        {
            Debug.Log(item);
        }

        //uso de pop para quitar de la pila y Enqueue para llenar la cola:
        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log("elemento peek de mi pila: " + pila.Peek());
            cola.Enqueue(pila.Peek());      
            pila.Pop();                  
        }
        Debug.Log("Asi queda la cola");
        foreach (var item in cola)
        {           
            Debug.Log(item);
        }
      
    }


}
