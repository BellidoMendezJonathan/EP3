using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class boss : MonoBehaviour
{
    private Animator ani;
    public Rigidbody2D rgb;
    public Transform jugador;
    private bool vd = true;
    public GameObject jefe;

    [Header("Vida")]
    [SerializeField] private float vida;
    [SerializeField] private BarraHP barrahp;
    [SerializeField] private float maxvida;

    [Header("ATTACK")]
    [SerializeField] private Transform attackchecker;
    [SerializeField] private float radio;
    [SerializeField] public float daño;


    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rgb = GetComponent<Rigidbody2D>();
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        barrahp.IniciarBarra(vida);
        vida = maxvida;
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        barrahp.CambiarHPactual(vida);
        if (vida <= 0)
        {
            ani.SetTrigger("die"); 
            Destroy(this, 0.8f);
            Invoke("morir", 3);
        }
    }

    void morir()
    {
       
        SceneManager.LoadScene("WIN");
    }
  
 
    public void Mirar() 
    {
    if((jugador.position.x > transform.position.x && !vd) || (jugador.position.x < transform.position.x && vd)) 
        {
            vd = !vd;

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        float distancia = Vector2.Distance(transform.position, jugador.position);
        ani.SetFloat("distancia",distancia);
    }
  public void Ataque()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(attackchecker.position, radio);

        foreach (Collider2D collision in objetos)
        {
            if(collision.CompareTag("Player"))
            {
                collision.GetComponent<hpjugador>().Tomardaño(daño);
            }
        }
    }

    public void OnDrawGizmos()
    {

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(attackchecker.position, radio);
    }
}
