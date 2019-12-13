using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneCity : MonoBehaviour
{
    public GameObject carro;
    public GameObject origin;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(carro);
        DontDestroyOnLoad(origin);
        SceneManager.LoadScene("scene1", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("z"))
        {
                
            SceneManager.LoadScene("scene2", LoadSceneMode.Single);
        
        }
    }
}
