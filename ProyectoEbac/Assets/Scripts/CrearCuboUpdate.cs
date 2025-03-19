using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrearCuboUpdate : MonoBehaviour
{

    public GameObject PrefabCubo;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboUpdate";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        Vector3 position = new Vector3(1.5f, 0.5f, 0.5f);
        tempGameObject.transform.position = position;
    }
}
