using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 1;
    public float speedRot = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log(Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(Time.deltaTime);
        transform.Translate(Vector3.right * speed * Input.GetAxis("Vertical")* Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward * speedRot * Input.GetAxis("Horizontal") * Time.deltaTime);
        //this.gameObject.transform.Rotate(Quaternion.EulerRotation(30, 0, 0));
    }
}
