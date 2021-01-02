
using UnityEngine;

public class FiniteStateMachine //: MonoBehaviour
{
    /*
        https://forum.unity.com/threads/c-proper-state-machine.380612/
        state machine implementation following a suggestion from the above blog post
        the FSM is based on Mat Buckland's
        changes are made to make it event driven with FSM Update method called only on button press
    */
    public IState currentState;//!!!!!!!! remove public

    public void ChangeState(IState newState)
    {
        if (currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }

    public void Update()
    {
        if (currentState != null) currentState.Execute();
        //print("currentState " + currentState);
    }
}
