using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : Istate
{
    private Vector2[] patrolPositions;
    private Transform ownerGO;
    private float speed;
    private int positionCount = 0;

    public patrol(Vector2[] patrolPositions, Transform ownerGO, float speed) 
    {
        this.patrolPositions = patrolPositions;
        this.ownerGO = ownerGO;
        this.speed = speed;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enter() 
    { }
    public void Execute() 
    {
        if (patrolPositions[positionCount] == (Vector2)ownerGO.position) 
        {
            positionCount++;
                if (positionCount > patrolPositions.Length - 1) positionCount = 0;
        }
        ownerGO.position = Vector2.MoveTowards(ownerGO.position, patrolPositions[positionCount], Time.deltaTime * speed);
    }
    public void Exit() 
    { }
}
