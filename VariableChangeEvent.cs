using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class VariableChangeEvent<T>
{
    [SerializeField] private T _value;

    public ValueGetBothEvent OnValueChangedGetBoth = new();
    public ValueGetEvent OnValueChangedGet = new();
    public ValueEvent OnValueChanged = new();

    // Property to get and set the value, triggering the event when set
    public T Value
    {
        get { return _value; }
        set
        {
            if (!EqualityComparer<T>.Default.Equals(_value, value))
            {
                OnValueChangedGetBoth.Invoke(_value, value);
                _value = value;
                OnValueChangedGet.Invoke(_value);
                OnValueChanged.Invoke();
            }
        }
    }

    [System.Serializable]
    public class ValueGetBothEvent : UnityEvent<T, T> { }
    [System.Serializable]
    public class ValueGetEvent : UnityEvent<T> { }
    [System.Serializable]
    public class ValueEvent : UnityEvent { }
}

