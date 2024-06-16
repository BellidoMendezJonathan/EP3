using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHARACTER : MonoBehaviour
{
    protected string _name;
    protected int _life;
    public CHARACTER(string name, int life)
    {
        _name = name;
        _life = life;

    }

    private int life;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Accion()
    {

        Debug.Log("hola" + _name);
    }
}
