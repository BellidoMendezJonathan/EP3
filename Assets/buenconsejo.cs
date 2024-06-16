using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buenconsejo : POLIPERSONAJE
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void SpecialNote()
    {
        base.SpecialNote();
        Debug.Log("¡Vamos! tú puedes, acaba con ellos porfavor confiamos en ti, entra en el abismo final te llevará a la guarida de su jefe");
    }
}
