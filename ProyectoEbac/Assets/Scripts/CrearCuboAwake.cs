using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{

    public GameObject PrefabCubo;
   

    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboAwake";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        Vector3 position = new Vector3(0.5f, 0.5f, 0.5f);
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
