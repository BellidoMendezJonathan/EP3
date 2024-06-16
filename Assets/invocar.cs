using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invocar : MonoBehaviour
{
    public Transform obj;
    public GameObject jefe;
    public bool perseguir;
    public float distancia;
    public float distanciaabsoluta;
   
    private void Update()
    {
        distancia = obj.position.x - transform.position.x;

        distanciaabsoluta = Mathf.Abs(distancia);

       
        if (distanciaabsoluta < 1)
        {
            jefe.SetActive(true);
            Destroy(gameObject);
        }


        else
        {
            perseguir = false;
        }

        
    }
}
