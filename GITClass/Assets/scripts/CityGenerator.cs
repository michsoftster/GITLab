using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class CityGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject[] calles = new GameObject [12];
    void Start()
    {
        Instantiate(carPrefab, Vector3.zero, Quaternion.Euler(-90f, 0f, -90f));

        CreateCity();
    }

    void CreateCity()
    {
        System.Random random = new System.Random();
        int index;
        for (int i = 0; i < 12; i++)
        {
            index = random.Next(0, 12);
            print(index);
            Instantiate(calles[index], new Vector3(0f, 0f, (i * 200f)), Quaternion.Euler(0f, 0f, 0f));
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
            CreateCity();
        }
    }
}
