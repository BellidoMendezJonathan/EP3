using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
public class mov : MonoBehaviour
{
    [SerializeField] Light2D on;
    [SerializeField] GameObject portal;
    [SerializeField] Text coins;
    public Camera cam;
    private int puntos;
    // Start is called before the first frame update
    void Start()
    {
        portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * 2.4f;

     if(coins.text== "Coins = 9") 
        {

            portal.SetActive(true);
            on.intensity = 1;
            cam.orthographicSize = 4;

        }   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "coin")
        {
            Destroy(collision.gameObject);
            puntos++;
            coins.text = "Coins = " + puntos.ToString();
        }
        if(collision.gameObject.name == "portal")
        {
            SceneManager.LoadScene("WIN");
        }
    }
   
}
