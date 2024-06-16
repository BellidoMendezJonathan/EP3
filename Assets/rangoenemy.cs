using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangoenemy : MonoBehaviour
{
    public Animator ani;
    public ghostpatrulla enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            ani.SetBool("walk", false);
            ani.SetBool("run", false);
            ani.SetBool("attack", true);
            enemy.atacando = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
