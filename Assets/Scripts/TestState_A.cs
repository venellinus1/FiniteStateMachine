
using UnityEngine;

public class TestState_A : IState
{
    Unit _owner;

    public TestState_A(Unit owner) { _owner = owner; }

    public void Enter()
    {
        Debug.Log("entering test state A");
    }

    public void Execute()
    {
        Debug.Log("Execute test state A");
    }

    public void Exit()
    {
        Debug.Log("exiting test state A");
    }
}
