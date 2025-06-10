using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugHelper : MonoBehaviour
{
    public static void Log(string _text)
    {
#if UNITY_EDITOR
        Debug.Log(_text);
#endif
    }

    public static void ShowRay(Vector3 start, Vector3 direction, Color color, float duration = 1f)
    {
#if UNITY_EDITOR
        Debug.DrawRay(start, direction, color, duration);
#endif
    }
}
