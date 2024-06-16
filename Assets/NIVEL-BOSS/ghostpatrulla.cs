using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostpatrulla : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public int direccion;
    public float speedw;
    public float speedrun;
    public GameObject target;
    public bool atacando;
    public float rangov;
    public float rangoa;
    public GameObject rango;
    public GameObject hit;
    public GameObject fantasma;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Player");
    }
    
    public void Comportamiento()
    { if (Mathf.Abs(transform.position.x - target.transform.position.x) > rangov && !atacando)
        {
            ani.SetBool("run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 2)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;

            }
            switch (rutina)
            {
                case 0:
                    ani.SetBool("walk", false);
                    break;
                case 1:
                    direccion = Random.Range(0, 2);
                    rutina++;
                    break;
                case 2:

                    switch (direccion)
                    {
                        case 0:
                            transform.rotation = Quaternion.Euler(0, 0, 0);
                            transform.Translate(Vector3.right * speedw * Time.deltaTime);
                            break;
                        case 1:
                            transform.rotation = Quaternion.Euler(0, 180, 0);
                            transform.Translate(Vector3.right * speedw * Time.deltaTime);
                            break;
                    }
                    ani.SetBool("walk", true);
                    break;
            }
        }
        else
        {
            if (Mathf.Abs(transform.position.x - target.transform.position.x) > rangoa && !atacando)
            { 
                if (transform.position.x < target.transform.position.x)
                {
                    ani.SetBool("walk", false);
                    ani.SetBool("run", true);
                    transform.Translate(Vector3.right * speedrun * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    ani.SetBool("attack", false);
                }
                else
                {
                    ani.SetBool("walk", false);
                    ani.SetBool("run", true);
                    transform.Translate(Vector3.right * speedrun * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    ani.SetBool("attack", false);
                }
            }
            else
            {
                if (!atacando)
                {
                    if (transform.position.x < target.transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                    ani.SetBool("walk", false);
                    ani.SetBool("run", false);
                }
            }
        }
    }

    public void anifi()
    {
        ani.SetBool("attack", false);
        atacando = false;
        rango.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void collidht()
    {
       hit.GetComponent<BoxCollider2D>().enabled = true;
    }
    public void collidhf()
    {
        hit.GetComponent<BoxCollider2D>().enabled = false;
    }
    void Update()
    {
        Comportamiento();


    }
  private void destrur()
    {
        Destroy(fantasma);
    }
   
}
