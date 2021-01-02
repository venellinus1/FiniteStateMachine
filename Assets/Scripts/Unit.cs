
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    
    public FiniteStateMachine stateMachine = new FiniteStateMachine();
    
    public Transform _this;

    void Start()
    {                                       
        _this = this.transform;       
        stateMachine.ChangeState(new StartState(this));
        
    }

    public void callFromSlide(Unit i) {//for testing 
        print(i.stateMachine.currentState);
    }

    public Transform InstantiateObj(Transform obj) {
        return Instantiate(obj);
    }
    public void StartChildCoroutine(IEnumerator coroutineMethod)
    {
        StartCoroutine(coroutineMethod);
    }

    

    void Update()
    {
        //test
        //stateMachine.Update();
        if (Input.GetKeyDown(KeyCode.A))
        {
            stateMachine.ChangeState(new TestState_A(this));
            stateMachine.Update();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            stateMachine.ChangeState(new TestState_B(this));
            stateMachine.Update();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            stateMachine.ChangeState(new TestState(this));
            stateMachine.Update();
        }

        
    }

    
    
    
}


