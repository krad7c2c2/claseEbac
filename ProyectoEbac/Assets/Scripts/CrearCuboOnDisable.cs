using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboOnDisable : MonoBehaviour
{
    public GameObject PrefabCuboOnEnable;
    public GameObject PrefabCuboOnDisable;


    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCuboOnEnable);
        tempGameObject.name = "CuboOnEnable";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        Vector3 position = new Vector3(4.5f, 0.5f, 0.5f);
        tempGameObject.transform.position = position;
    }


    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCuboOnEnable);
        tempGameObject.name = "CuboOnDisable";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        Vector3 position = new Vector3(6.5f,0.5f, 0.5f);
        tempGameObject.transform.position = position;
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
