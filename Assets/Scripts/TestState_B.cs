
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class TestState_B : IState
{
    Unit _owner;
    
    public TestState_B(Unit owner) { _owner = owner; }

    public void Enter()
    {
        Debug.Log("entering test state B");       
    }

    public void Execute()
    {
        Debug.Log("updating test state B");        
    }    

    public void nextState() {        
        Debug.Log("B goes to next state using stateMachine.ChangeState");
        _owner.stateMachine.ChangeState(new TestState_A(_owner));
    }

    public void Exit()
    {
        Debug.Log("exiting test state B");
    }

  
    
}
