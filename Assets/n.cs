using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class n : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
       
        if (gameObject.CompareTag("u") && Input.GetKey(KeyCode.U))
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("r") && Input.GetKey(KeyCode.R))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("j") && Input.GetKey(KeyCode.J))
        {
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("g") && Input.GetKey(KeyCode.G))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (gameObject.CompareTag("d") && Input.GetKey(KeyCode.D) && Input.GetMouseButton(2))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("n") && Input.GetKey(KeyCode.N) && Input.GetMouseButton(1))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("m") && Input.GetKey(KeyCode.M) && Input.GetMouseButton(1))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("s") && Input.GetKey(KeyCode.S) && Input.GetMouseButton(1))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("h") && Input.GetKey(KeyCode.H) && Input.GetMouseButton(2))
        {
            Destroy(gameObject);
        }
        if (gameObject.CompareTag("i") && Input.GetKey(KeyCode.I) && Input.GetMouseButton(2))
        {
            Destroy(gameObject);
        }
    }
    
}