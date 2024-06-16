using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundimplemt : MonoBehaviour
{
    public AudioSource clip;
    public GameObject gameObjectt;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            clip.Play();
            gameObject.SetActive(false);
            gameObjectt.GetComponent<hpjugador>().hp += 10;
        }
    }
}
        
