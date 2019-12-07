using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CityGenerator : MonoBehaviour
{
    public GameObject carPrefab;
   public GameObject [] calles = new GameObject [12];
    void Start()
    {
        Instantiate(carPrefab,
                    Vector3.zero,
                    Quaternion.Euler(-90f,
                                        0f,
                                        0f));
                                     
        CreateCity(
          
        );
    }

    // Update is called once per frame
    void CreateCity()
    {
                  
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0,LoadSceneMode.Single);
    }
    }
}
