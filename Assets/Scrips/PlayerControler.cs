using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float velGiro=20
    // Start is called before the first frame update
    private float avanza;
    private float gira;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float avanza =Input.GetAxis('Vertical');
        float gira =Input.GetAxis('Horizontal');
        transform.Translate(Vector3.forward*Time.deltaTime*20*avanza);
        transform.Rotate(Vector3.up,Time.deltatime*velGiro*gira);
        
    }
}
