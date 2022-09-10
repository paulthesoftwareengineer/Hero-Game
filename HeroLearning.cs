sing System.Collections;
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

    //Start method
    void start ()
    {
       ComputeAge();
    }

    //Compute Age method
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
