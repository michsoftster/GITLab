using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CityGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject[] roadPrefab = new GameObject[10];
    GameObject[] calles = new GameObject[10];
    void Start()
    {
        Instantiate(carPrefab, Vector3.zero, Quaternion.Euler(-90f, 0f, 0f));
        CreateCity();
    }

    void CreateCity()
    {
        for (int i = 0; i < calles.Length; i++)
        {
            Destroy(calles[i]);
            calles[i] = Instantiate(roadPrefab[Random.Range(0, roadPrefab.Length)], Vector3.forward * i * 200f, Quaternion.Euler(0f, 0f, 0f));
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            CreateCity();
        }
    }
}
