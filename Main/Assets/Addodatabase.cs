using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addodatabase : MonoBehaviour {

    public InputField something;
    private string word;
    public Emails otherObject;
    public void Setget()
    {
        something.text = word;
        Debug.Log(word);
        otherObject.Addsave(word);
        something.text = "";
    }
    
}
