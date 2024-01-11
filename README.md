# Unity Variable Change Event

This repository contains a versatile and easy-to-use script for Unity, designed to handle variable changes with events. The VariableChangeEvent<T> class allows you to encapsulate a variable and trigger events when its value changes. It provides three types of events:

OnValueChangedGetBoth: Invoked with both the old and new values when the variable changes.
OnValueChangedGet: Invoked with the new value when the variable changes.
OnValueChanged: Invoked with no arguments when the variable changes.

Additionally, each event type is implemented as a UnityEvent, making it easy to connect to various Unity components through the Inspector. This script simplifies the process of responding to changes in your variables, enhancing modularity and maintainability in your Unity projects.

Feel free to use, modify, and contribute to this script to suit your specific needs. Happy coding!
