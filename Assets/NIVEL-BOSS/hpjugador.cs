using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hpjugador : MonoBehaviour
{
    public GameObject player;
    [SerializeField] public float hp;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }
    public void Tomardaño(float daño) 
    {
        hp -= daño;
        Debug.Log("daño");
        if(hp <= 0) 
        {
            player.tag = new("muerto");
            Invoke("muerte", 3);
            anim.SetTrigger("die");
            player.GetComponent<movplayer>().enabled = false;
            
            player.GetComponent<melé>().enabled = false;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void muerte() 
    {
        SceneManager.LoadScene("lose");
    }
}
