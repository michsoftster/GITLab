using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CityGenerator : MonoBehaviour
{

    public GameObject[] carreteras = new GameObject[10];
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(carreteras[Random.Range(0, 10)],Vector3.forward*(i*200),Quaternion.Euler(0,0,0));
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
