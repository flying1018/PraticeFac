using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum PlayerState
    {
        Idle,
        Run,
        Jump,
        Fall,
        Inventory,
    }

    private PlayerState currentState;
    private Coroutine stateCoroutine;

    private void Awake()
    {
        ChangeState(PlayerState.Idle);
    }
    private void Update()
    {
        currentState.OnUpdate();
    }

    public void ChangeState(PlayerState newState)
    {
        if (stateCoroutine != null)
        {
            StopCoroutine(stateCoroutine);
            stateCoroutine = null;
        }

        currentState = newState;
        StartCoroutine(stateCoroutine.ToString());
    }
    private IEnumerator Idle()
    {
        return null;
    }

    private IEnumerator Run()
    {
        return null;
    }

    private IEnumerator Jump()
    {
        return null;
    }

    private IEnumerator Fall()
    {
        return null;
    }

    private IEnumerator Inventory()
    {
        return null;
    }
}
