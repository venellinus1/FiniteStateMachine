
using UnityEngine;
using UnityEngine.UI;

public class StartState : IState
{
    Unit _owner;

    public StartState(Unit owner) { _owner = owner; }

    public void Enter()
    {
        Debug.Log("entering start state");
    }

    public void Execute()
    {
        Debug.Log("updating start state");
    }

    public void nextState()
    {
        Debug.Log("Btn configclick");
        _owner.stateMachine.ChangeState(new TestState(_owner));
    }
    public void Exit()
    {
        Debug.Log("exiting start state");        
    }
}
