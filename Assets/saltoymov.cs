using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltoymov : MonoBehaviour

{
    public float speed;
    public float alturasalto;
    public float potsalto;
    private float gravedad;
    public float fallen;
    private int fase1;
    private int fase2;
    public Animator ani;
    public float PosY;
    private int sky;
    public bool Saltando;
    private RaycastHit2D hit;
    public Vector3 v3;
    public float distance;
    public LayerMask layer;
    public int numero_Saltos;



    void Awake()
    {
        ani = GetComponent<Animator>();    
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position + v3, Vector3.up * -1 * distance);
    }

    public bool Checkhit
    {
        get
        {
            hit = Physics2D.Raycast(transform.position + v3, transform.up * -1, distance, layer);
            return hit.collider != null;
        }
    }

    public void detectorplat() 
    {
        if (Checkhit)
        {
            ani.SetBool("sky", false);
            sky = 0;
            if (!Saltando)
            {

                gravedad = 0;
                fase1 = 0;
                fase2 = 0;
            }

        }
        else

        {
            ani.SetBool("sky", true);
            if (!Saltando)
            {
                switch (fase2)
                {
                    case 0:
                        gravedad = 0;
                        fase2 = 1;
                        ani.Play("Base Layer.sky", 0, 0);
                        break;

                    case 1:
                        if (gravedad > -10)
                        {
                            gravedad -= alturasalto / fallen * Time.deltaTime;
                        }
                        break;
                }
            }
        }


            
        
        
        
        if (transform.position.y > PosY)
        
        {
            ani.SetFloat("gravedad", 1);
        }
        if (transform.position.y < PosY) 
        {
            ani.SetFloat("gravedad", 0);

            switch (sky)

            {
                case 0:
                    ani.Play("Base Layer.sky", 0, 0);
                    sky++;
                    break;

            }


            PosY = transform.position.y;
        }

    
    }

    public void salto()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            switch (fase1)
            {
                case 0:
                    if (Checkhit &&  numero_Saltos > 0)

                    {
                        gravedad = alturasalto;
                        fase1 = 1;
                        Saltando = true;
                        numero_Saltos--;
                    }
                    break;

                case 1:
                    if (gravedad > 0)
                    {
                        gravedad -= potsalto * Time.deltaTime;
                    }
                    else
                    {
                        fase1 = 2;
                    }
                    Saltando = true;
                    break;
                case 2:
                    Saltando = false;
                    break;
            }

        }
        else Saltando = false;
        if (Checkhit) 
        {
            numero_Saltos = 1;
        }
    }

    public void Mov()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            ani.SetBool("run", true);
        }
        else
        {
            ani.SetBool("run", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            ani.SetBool("run", true);
        }
    }
    private void FixedUpdate()
    {
        Mov();
        salto();
    }
    void Start()
    {
        
    }

 
    void Update()
    {
        detectorplat();
        transform.Translate(Vector3.up* gravedad * Time.deltaTime);
    }
}
