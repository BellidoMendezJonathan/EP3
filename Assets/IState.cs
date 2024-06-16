using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Istate : MonoBehaviour
{
    public IState currentlyRunningState;
    public IState previousstate;
    public interface IState
{
        void Enter();
        void Execute();
        void Exit();
}

   public void ChangeState(IState newState) 
    {

        if(this.currentlyRunningState != null)
        {
            this.currentlyRunningState.Exit();
        }
        this.previousstate = this.currentlyRunningState;

        this.currentlyRunningState = newState;
        this.currentlyRunningState.Enter();

    }
    public void ExecuteStateUpdate()
    {
        if (this.currentlyRunningState != null)
        {
            this.currentlyRunningState.Execute();
        }
    }
     public void SwitchToPreviousState() 
    {
        this.currentlyRunningState.Exit();
        this.currentlyRunningState = this.previousstate;
        this.currentlyRunningState.Execute();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
