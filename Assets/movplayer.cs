using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enumerador;

public class movplayer : MonoBehaviour
{
    public GameObject levelp;
    public GameObject player;
    private Rigidbody2D rb;
    [Header("Movimiento")]
    private float movimientohorizontal = 0;
    [SerializeField] public float velocidadmov;
    [SerializeField] private float suavizado;
    private Vector3 velocidad = Vector3.zero;
    private bool derecha = true;

    [Header("Salto")]

    [SerializeField] public float fuerzasalto;
    [SerializeField] private LayerMask suelo;
    [SerializeField] private Transform controlador;
    [SerializeField] private Vector3 caja;
    [SerializeField] private bool ensuelo;
    private bool salto = false;

    [Header("Animación")]
    private Animator anim;

    [Header("Exp")]
   
    private int experience;
    public int Experience
    {
        get { return experience; }
        set
        {
            if (value < 0)
            {
                Debug.Log("Experience cannot be negative.");
                experience = 0;
            }
            else
            {
                experience = value;

                LevelUp();
                
            }
        }
    }

    public void PrintInfo()
    {
        
        Debug.Log("Player level: " + Level);
        Debug.Log("Player experience: " + Experience);
    }
    

    public void GainExperience(int amount)
    {
        Experience += amount;
    }
    public int Level { get; private set; }


    private void LevelUp()
    {

        Level = experience / 100 + 1;

        levelp.SetActive(true);
        Invoke("stopl", 0.5f);

       
    }


    // Start is called before the first frame update
    void Start()
    {
        enumerador.ChangeAmbientSound(AmbientSoundState.Peaceful);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        movimientohorizontal = Input.GetAxisRaw("Horizontal") * velocidadmov;

        anim.SetFloat("horizontal", Mathf.Abs(movimientohorizontal));
        anim.SetFloat("YVEL", rb.velocity.y);


        if (Input.GetButtonDown("Jump"))
        {
            salto = true;


        }


    }
    private void FixedUpdate()
    {
        ensuelo = Physics2D.OverlapBox(controlador.position, caja, 0f, suelo);
        Move(movimientohorizontal * Time.fixedDeltaTime, salto);
        salto = false;

        anim.SetBool("enSuelo", ensuelo);
    }

    private void Move(float mover, bool saltar)
    {
        Vector3 velocidadobjetivo = new Vector2(mover, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, velocidadobjetivo, ref velocidad, suavizado);
        if (mover > 0 && !derecha)
        {
            Girar();
        }
        else if (mover < 0 && derecha)
        {
            Girar();
        }

        if (ensuelo && saltar)
        {

            ensuelo = false;
            rb.AddForce(new Vector2(0f, fuerzasalto));
        }

    }

    private void Girar()
    {
        derecha = !derecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(controlador.position, caja);
    }

    void stopl()
    {
        levelp.SetActive(false);
    }

}