using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAGE : CHARACTER
{
   
    private int _mana;


    public MAGE(string name, int life, int mana) : base(name, life)

    {
        _mana = mana;
        Accion();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
