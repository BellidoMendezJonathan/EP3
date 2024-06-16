using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balas : MonoBehaviour
{
    
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    public void Shoot() 
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            GameObject obj = Instantiate(bullet, transform.position, transform.rotation);
           
        }
    }
  
}
