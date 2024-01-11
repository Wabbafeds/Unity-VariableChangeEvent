# Unity Variable Change Event

This repository contains a versatile and easy-to-use script for Unity, designed to handle variable changes with events. The VariableChangeEvent<T> class allows you to encapsulate a variable and trigger events when its value changes. It provides three types of events:

**OnValueChangedGetBoth**: Invoked with both the old and new values when the variable changes.

**OnValueChangedGet**: Invoked with the new value when the variable changes.

**OnValueChanged**: Invoked with no arguments when the variable changes.

Additionally, each event type is implemented as a UnityEvent, making it easy to connect to various Unity components through the Inspector. This script simplifies the process of responding to changes in your variables, enhancing modularity and maintainability in your Unity projects.

Feel free to use, modify, and contribute to this script to suit your specific needs. Happy coding!

## Usage example

```
public class VariableChangeEventExample : MonoBehaviour
{
    [SerializeField]
    private VariableChangeEvent<int> myIntVariable = new VariableChangeEvent<int>();

    private void Start()
    {
        // Subscribe to the OnValueChangedGetBoth event
        myIntVariable.OnValueChangedGetBoth.AddListener(HandleValueChangedGetBoth);

        // Subscribe to the OnValueChangedGet event
        myIntVariable.OnValueChangedGet.AddListener(HandleValueChangedGet);

        // Subscribe to the OnValueChanged event
        myIntVariable.OnValueChanged.AddListener(HandleValueChanged);

        // Change the value, triggering the events
        myIntVariable.Value = 42;
    }

    private void HandleValueChangedGetBoth(int oldValue, int newValue)
    {
        Debug.Log($"Value changed from {oldValue} to {newValue}");
    }

    private void HandleValueChangedGet(int newValue)
    {
        Debug.Log($"New value is: {newValue}");
    }

    private void HandleValueChanged()
    {
        Debug.Log("Value changed without specific details");
    }
}

```


