using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int num = 5;

    public List<string> list = new List<string>();

    void Start()
    {
        Debug.Log($"Hello World! = {num}");
        PrintList();
    }


    void PrintList()
    {
        list.ForEach(Debug.Log);
    }
}
