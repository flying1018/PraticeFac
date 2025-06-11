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
    private bool isInventory;

    private void Awake()
    {
        ChangeState(PlayerState.Idle);
    }
    private void Update()
    {

    }

    public void ChangeState(PlayerState newState)
    {
        if (stateCoroutine != null)
        {
            StopCoroutine(stateCoroutine);
            stateCoroutine = null;
        }

        currentState = newState;

        switch (newState)
        {
            case PlayerState.Idle:
                stateCoroutine = StartCoroutine(Idle());
                break;
            case PlayerState.Run:
                stateCoroutine = StartCoroutine(Run());
                break;
            case PlayerState.Jump:
                stateCoroutine = StartCoroutine(Jump());
                break;
            case PlayerState.Fall:
                stateCoroutine = StartCoroutine(Fall());
                break;
            case PlayerState.Inventory:
                stateCoroutine = StartCoroutine(Inventory());
                break;
        }
    }
    private IEnumerator Idle()
    {
        DebugHelper.Log("기본 상태 진입");

        while (true)
        {
            yield return null;
        }
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
        if (!isInventory)
        {
            isInventory = true;
            DebugHelper.Log("인벤토리 상태 진입");

            UIManager.Instance.ShowInventory();
            UIManager.Instance.ShowEquipment();
            UIManager.Instance.ShowChest();
        }
        else if (isInventory)
        {
            isInventory = false;
            DebugHelper.Log("인벤토리 상태 해제");

            UIManager.Instance.HideInventory();
            UIManager.Instance.HideEquipment();
            UIManager.Instance.HideChest();
            ChangeState(PlayerState.Idle);
        }


        while (true)
            {
                yield return null;
            }
    }
}
