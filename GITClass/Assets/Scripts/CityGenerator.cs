using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject carPrefab;
    public GameObject[] TodasLasPistas = new GameObject[12];
   
    void Start()
    {
        Instantiate(carPrefab, Vector3.zero, Quaternion.Euler(-90f, 0f, 0f));
        CreateCity();

    }

    private void CreateCity()
    {
        for (int i = 0; i <= 10; i++)
        {
            int number = UnityEngine.Random.Range(0, 12);
            Instantiate(TodasLasPistas[number], new Vector3(0,0, 200 * i), Quaternion.Euler(0, 0f, 0f));
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
