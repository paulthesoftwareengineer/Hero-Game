using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //global variables
    private int currentAge = 19;
    public int addedAge =  1;
    public string firstName ="Holy";
    public string lastName ="Warrior";
    public bool isCharacter = true;
    int characterHealth = 22;

    //Start method
    void start ()
    {
       //int characterHealth = 22;
        ComputeAge();
        Debug.Log($"Warrior's first name is {firstName}!");
    }

    //Compute Age method
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge + characterHealth);
    }
}
