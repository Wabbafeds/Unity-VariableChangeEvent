using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class VariableChangeEvent<T>
{
    #region Constructors
    public VariableChangeEvent(T variable)
    {
        _value = variable;
    }
    public VariableChangeEvent() { }
    #endregion

    [SerializeField] private T _value;

    public ValueGetBothEvent OnValueChangedGetBoth = new();
    public ValueGetEvent OnValueChangedGet = new();
    public ValueEvent OnValueChanged = new();

    // Property to get and set the value, triggering the events when set
    public T Value
    {
        get { return _value; }
        set
        {               
            OnValueChangedGetBoth.Invoke(_value, value);
            _value = value;
            OnValueChangedGet.Invoke(_value);
            OnValueChanged.Invoke();       
        }
    }

    //Property to set the value without triggering the events
    public T ValueNoEventTrigger
    {
        set
        {              
            _value = value;
        }
    }

    [System.Serializable]
    public class ValueGetBothEvent : UnityEvent<T, T> { }
    [System.Serializable]
    public class ValueGetEvent : UnityEvent<T> { }
    [System.Serializable]
    public class ValueEvent : UnityEvent { }
}


