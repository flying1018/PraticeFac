using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void OnEnter(); // 진입시
    void OnUpdate(); // 하는 과정
    void OnExit(); // 끝날시
}
