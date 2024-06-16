using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DIALOGOSYSTEM : MonoBehaviour
{
    public Text dialogue;
    public GameObject panel;
    public float typingSpeed;
    [TextArea(3, 10)] public string[] sentences;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(true);
        StartCoroutine(Typing());
        
    }

    // Update is called once per frame

    IEnumerator Typing()
    {

        foreach (char letter in sentences[index].ToCharArray())
        {
            dialogue.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

    }

    public void NextSentence()
    {
        if(index < sentences.Length -1)
        {
            index++;
            dialogue.text = "";
            StartCoroutine(Typing());

        }
        else 
        {
           
            panel.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StopAllCoroutines();
            NextSentence();
        }
    }
    private void ola() 
    {
        SceneManager.LoadScene("ola");
    }
}

