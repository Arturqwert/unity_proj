using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSript : MonoBehaviour
{
    public Color color;
    public GameObject sphere;
    public Camera cam;

    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
        y = cam.transform.position.y;
        z = cam.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    { 
        sphere.transform.position = gameObject.transform.position + new Vector3(0, gameObject.transform.position.y + 0.3f, 0);

        cam.transform.position = new Vector3(transform.position.x - 4, y, z);

        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0.02f, 0, 0);
        }
    }
}
