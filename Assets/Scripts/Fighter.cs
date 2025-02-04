using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter
{
    public int Strength;
    public string Name;

    public void Speak()
    {
        Debug.Log(this.GetSpeech());
    }
    public string GetSpeech()
    {
        return $"My name is {this.Name} and I have {this.Strength} strength\n";
    }
}

