using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class scr : MonoBehaviour
{

    //public GameObject Dino;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += new Vector3(-0.02f,0,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.transform.eulerAngles += new Vector3(0,0.1f,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            gameObject.transform.eulerAngles += new Vector3(0, -0.1f, 0);
        }
    }
}
