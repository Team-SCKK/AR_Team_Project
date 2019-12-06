using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BooleanEventHandler : MonoBehaviour
{
    public UnityEvent onTrue;
    public UnityEvent onFalse;
    public bool toggle = false;

    public void OnTrue()
    {
        onTrue.Invoke();
    }

    public void OnFalse()
    {
        onFalse.Invoke();
    }

    public void ToggleBoolean()
    {
        toggle = false ? true : false;
    }
}
