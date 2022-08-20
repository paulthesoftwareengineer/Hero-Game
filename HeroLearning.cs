using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public string characterClass = "Marine";
    private int currentAge = 19;
    public int addedAge =  1;

    public float cloud = 10f;
    public string clanName = "Warrior";
    public bool isMarine = true;


    // Start is called before the first frame update
   /* void Start()
    {
        ComputeAge();
        int characterHealth = 100;
        Debug.Log(characterClass + " - HP:" + characterHealth);
        Debug.Log($"The health of {clanName} is {characterHealth}!");


    } */

    void start ()
    {
        GenerateCharacter()
    }

    public void GenerateCharacter ()
    {
        Debug.Log(Character: Marine)
    }

    


   /* void CreateCharacter()
    {
        int characterName = "Warrior";
        Debug.Log(characterName + "-" + characterClass);
    } */


    // Update is called once per frame
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
