using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.5f;
    private float oldMousePositionX;
    private float eulerY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            oldMousePositionX = Input.mousePosition.x;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 newPos = transform.position + transform.forward * Time.deltaTime  * speed;
            newPos.x = Mathf.Clamp(newPos.x, -1.7f, 1.7f);
            transform.position = newPos;

            float deltaX = Input.mousePosition.x - oldMousePositionX;
            oldMousePositionX = Input.mousePosition.x;

            eulerY += deltaX;
            eulerY = Mathf.Clamp(eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, eulerY, 0);
        }
    }
}
