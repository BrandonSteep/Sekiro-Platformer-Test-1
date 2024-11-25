using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Variable/int")]
public class ScriptableVariable_int : ScriptableObject
{
    [SerializeField] private int value;

    public int GetValue(){
        return value;
    }

    public void SetValue(int valueToSet){
        value = valueToSet;
    }

    public void AddToValue(int valueToAdd){
        value += valueToAdd;
    }
}
