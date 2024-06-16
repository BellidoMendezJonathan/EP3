using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habjefe : MonoBehaviour
{
    [SerializeField] private float daño1;
    [SerializeField] private Vector2 tmñcaja;
    [SerializeField] private Transform posicioncj;
    [SerializeField] private float tiempovd;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempovd);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Golpe() 
    {
        Collider2D[] objetos = Physics2D.OverlapBoxAll(posicioncj.position, tmñcaja, 0f);

        foreach(Collider2D colisiones in objetos) 
        {
        if(colisiones.CompareTag( "player"))
            {
                colisiones.GetComponent<hpjugador>().Tomardaño(daño1);

            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(posicioncj.position, tmñcaja);
    }
}
