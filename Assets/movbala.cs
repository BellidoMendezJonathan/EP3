using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movbala : MonoBehaviour
{
    public float daño;
    public hpboos restar;
    public float speed;
   
    public GameObject jefe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private  void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("objetivo"))
        {
            
            Destroy(gameObject);
         restar.Restarhp(daño);
        }
       
    }
}
