using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WARRIOR : CHARACTER
{
   
    private int _rage;


    public WARRIOR(string name, int life, int rage) : base(name, life) 
    
    {
        _rage = rage;
        Accion();
    }
    // Start is called before the first frame update
    private void Charge() 
    {
        
    }

  
}
