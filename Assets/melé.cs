using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melé : MonoBehaviour
{
    [SerializeField] private float daño;
    [SerializeField] private float radio;
    [SerializeField] private Transform controlador;
    private Animator anim;
    [SerializeField] private float tiempoattack;
     [SerializeField] private float tiemposigattack;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {if(tiemposigattack > 0)
        {
            tiemposigattack -= Time.deltaTime;
        }
        if(Input.GetButtonDown("Fire1")  && tiemposigattack <=  0)
        {
            Golpe();
            tiemposigattack = tiempoattack;
        }
    }

    private void Golpe()
    {
        anim.SetTrigger("golpe");
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controlador.position, radio);

        foreach(Collider2D collisionador in objetos) 
        {
            if (collisionador.CompareTag("Enemy")) 
            {
                collisionador.transform.GetComponent<boss>().TomarDaño(daño);
              
            }
            if (collisionador.CompareTag("minions"))
            {
                collisionador.transform.GetComponent<hpenemigos>().Tomardaño(daño);
               
            }
            if(collisionador.CompareTag("bala"))
            { collisionador.transform.GetComponent<batbullet>().Tomardaño(daño); }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controlador.position, radio);
    }
   
}


