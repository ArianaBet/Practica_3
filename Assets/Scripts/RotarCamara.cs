using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaciondecamara : MonoBehaviour
{
    public float speeddH;
    public float speedV;

    float y;
    float x;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        y += speeddH * Input.GetAxis("Mouse X");
        x -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(x, y, 0);
    }
}