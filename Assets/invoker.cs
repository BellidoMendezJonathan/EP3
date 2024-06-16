using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoker :hpenemigos
{
    public Transform obj;
    
    private Animator anim;
    public float distancia;
    public float distanciaabsoluta;
    public hpjugador hpj;
    [SerializeField] private Transform player;
    [SerializeField] private Transform shootpos;
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    private void Start()
    {
       
        // expp.SetActive(false);
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float distancia = (obj.position.x + obj.position.y) - (transform.position.x + transform.position.y);

        distanciaabsoluta = Mathf.Abs(distancia);

        if (distancia > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (distancia < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (distanciaabsoluta < 11)

        {
           
            anim.SetBool("permit", true);
        }
        else anim.SetBool("permit", false);


    }
    public void invok()

    {
        float speed = 6f;
        GameObject bullett = Instantiate(bullet, shootpos.position, Quaternion.identity);
        Rigidbody2D bulletrb = bullett.GetComponent<Rigidbody2D>();
        bulletrb.velocity = (player.transform.position - transform.position).normalized * speed;

    }
    protected override void Muerte()
    {

        base.Muerte();
        Invoke("Expp", 0.4f);
        expp.SetActive(true);
    }
    private void Expp()
    {
        expp.SetActive(false);
    }
}

