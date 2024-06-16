using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject objetivo;
    public float velocidad = 5f;
  


    private void Start()
    {

        
        objetivo = GameObject.Find("player");
    }
    void Update() { }



    private void OnTriggerEnter2D(Collider2D collision)
    { 
            Vector3 direccion = (objetivo.transform.position - transform.position).normalized;
            transform.Translate(direccion * velocidad * Time.deltaTime);
        }

    }
  


