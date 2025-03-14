using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboOnDisable2 : MonoBehaviour
{

    GameObject objToSpawm;
    Vector3[] vertices = {
            new Vector3 (0,0,0),
             new Vector3 (1,0,0),
              new Vector3 (1,1,0),
               new Vector3 (0,1,0),
                new Vector3 (0,1,1),
                 new Vector3 (1,1,1),
                  new Vector3 (1,0,1),
                   new Vector3 (0,0,1),
        };
    int[] triangulos = {
           0,2,1, //cara1
           0,3,2,
           2,3,4, //cara 2
           2,4,5,
           1,2,5,//cara3
           1,5,6,
           0,7,4,  //cara 4
           0,4,3,
           5,4,7, //cara 5
           5,7,6,
           0,6,7, //cara 6
           0,1,6
    };



    private void OnEnable()
    {
        objToSpawm = new GameObject("CuboEnOnEnable2");
        objToSpawm.AddComponent<MeshFilter>();
        var meshFilter = objToSpawm.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals(); //asegura el reenderizado correcto
        objToSpawm.AddComponent<BoxCollider>();
        var boxCollider = objToSpawm.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawm.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawm.GetComponent<MeshRenderer>().material;
        //Color c = new Color(Random.value, Random.value, Random.value);
        //meshRendererMaterial.color = c;
        objToSpawm.transform.position = new Vector3(10f, 1f, 1f);
    }

    private void LateUpdate()
    {

        CrearCuboOnDisable cuboScript = GetComponent<CrearCuboOnDisable>();
        CrearCuboOnDisable1 cuboUpdate = GetComponent<CrearCuboOnDisable1>();

        // Ahora puedes acceder a otras propiedades del script si no fueran est�ticas
        bool estado = cuboScript.valueObject3;
        bool estado2 = cuboUpdate.valueObject4;

        var meshRendererMaterial = objToSpawm.GetComponent<MeshRenderer>().material;
        if (estado && estado2)
        {
            meshRendererMaterial.color = Color.white;
        }
        else
        {
            meshRendererMaterial.color = Color.black;
        }
    }


    private void OnDisable()
    {
        /*
        objToSpawm = new GameObject("CuboEnOnDisable");
        objToSpawm.AddComponent<MeshFilter>();
        var meshFilter = objToSpawm.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals(); //asegura el reenderizado correcto
        objToSpawm.AddComponent<BoxCollider>();
        var boxCollider = objToSpawm.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawm.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawm.GetComponent<MeshRenderer>().material;
        Color c = new Color(Random.value, Random.value, Random.value);
        meshRendererMaterial.color = c;
        objToSpawm.transform.position = new Vector3(12f, 1f, 1f);
        */
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
