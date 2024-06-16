using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerdia : MonoBehaviour
{
    //public class FighterManager : MonoBehaviour


    private void Start()
    {

        Aldeanobueno aldb = gameObject.AddComponent<Aldeanobueno>();
        Aldeanomalo aldm = gameObject.AddComponent<Aldeanomalo>();


        aldb.SpecialNote();
        aldm.SpecialNote();
    }

}
