using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRACTICA : MonoBehaviour
{
    CHARACTER myCharacther;
    WARRIOR myWarrior;
    MAGE myMage;

    PRACTICA mypractica;
    // Start is called before the first frame update
    void Start()
    {
        myCharacther = new CHARACTER("Minion", 100);
        myWarrior = new WARRIOR("Skeleton", 150, 100);
        myMage = new MAGE("Wizzard", 75, 100);

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
