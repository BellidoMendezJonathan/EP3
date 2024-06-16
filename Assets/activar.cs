using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activar : MonoBehaviour
{
    public GameObject puerta;
    public GameObject jefe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("weso") )
        {
            Destroy(puerta);
            jefe.SetActive(true);
        }
    }
}
