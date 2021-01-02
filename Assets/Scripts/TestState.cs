
using UnityEngine;

public class TestState : IState
{
    Unit _owner;

    public TestState(Unit owner) { _owner = owner; }

    public void Enter()
    {
        Debug.Log("entering test state");
    }

    public void Execute()
    {
        Debug.Log("updating test state");
    }

    public void Exit()
    {
        Debug.Log("exiting test state");
    }
}
