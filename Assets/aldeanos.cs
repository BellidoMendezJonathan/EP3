using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    protected AudioSource au;
   
    public virtual void SpecialNote()
    {
        Debug.Log("nada");

    }
}

public class Aldeanobueno : Character
{

    public override void SpecialNote()
    {


        Debug.Log("Ten cuidado con los murcielagos ocasionan mucho da�o por segundo");
      
    }

}

public class Aldeanomalo : Character
{
    public override void SpecialNote()
    {

        Debug.Log("Ayudanos");

    }


}


