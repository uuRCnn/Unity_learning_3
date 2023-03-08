using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi_manager : MonoBehaviour
{
    private float mermiHızı = 15f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * mermiHızı);
    }
}
