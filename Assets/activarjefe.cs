using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static enumerador;

public class activarjefe : MonoBehaviour
{
    public GameObject jefe;
    public GameObject slider;

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
            enumerador.ChangeAmbientSound(AmbientSoundState.Combat);
            jefe.SetActive(true);
            slider.SetActive(true);
        }
    }
}
