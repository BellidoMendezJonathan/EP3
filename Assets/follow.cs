using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class follow : MonoBehaviour
{
    public Transform objetivo; 
    public float suavizado = 5f; 

    private void Update()
    {
        if (objetivo != null)
        {
            Vector3 posicionDeseada = objetivo.position;
            posicionDeseada.z = transform.position.z; 
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
        }
    }
}

