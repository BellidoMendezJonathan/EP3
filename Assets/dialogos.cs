using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogos : MonoBehaviour
{
    
    [SerializeField] private GameObject cb;
    private bool Isinrange;
    private bool dialogo;
    private int lineIndex;
    [SerializeField, TextArea(4, 6)] private string[] lineas;
    [SerializeField] private GameObject panel;
    [SerializeField] private TMP_Text textoo;
    void Update()
    {
        if (Isinrange == true && Input.GetKeyDown(KeyCode.Q))
        {
            if (!dialogo)
            {
                StarDialogo();
            }
            else if (textoo.text == lineas[lineIndex])
            {
                Nextdialogo();
            }
            else 
            {
                StopAllCoroutines();
                textoo.text = lineas[lineIndex];
            }
        }
      
    }
    private void StarDialogo()
    {
        dialogo = true;
        panel.SetActive(true);
        cb.SetActive(false);
        lineIndex = 0;
        StartCoroutine(SHOW());
        Time.timeScale = 0f;
    }
    private void Nextdialogo()
    {
        lineIndex++;
        if (lineIndex < lineas.Length)
        {
            StartCoroutine(SHOW());
        }
        else
        { dialogo = false;
            panel.SetActive(false);
            cb.SetActive(true);
            Time.timeScale = 1f;
        }
    }
    private IEnumerator SHOW() 
    {
        textoo.text = string.Empty;
        foreach(char ch in lineas[lineIndex])
        {
            textoo.text += ch;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player") 
        {
            Isinrange = true;
            cb.SetActive(true);
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Isinrange = false;
            cb.SetActive(false);
        }
    }
}
