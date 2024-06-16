using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    Vector3 enemypos;
    public Transform player;
        bool perseguir;
    public int speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

}
