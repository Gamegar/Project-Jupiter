using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour
{
    private BasePlayer newPlayer;
    private bool isClericClass;
    private bool isFighterClass;
    private bool isRougeClass;
    private bool isWizardClass;
    private string playerName = "Enter Name";

    // Start is called before the first frame update
    void Start()
    {
        newPlayer = new BasePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName,15);
        isWizardClass = GUILayout.Toggle(isWizardClass, "Wizard Class");
        isFighterClass = GUILayout.Toggle(isFighterClass, "Fighter Class");
        isRougeClass = GUILayout.Toggle(isRougeClass, "Rouge Class");
        isClericClass = GUILayout.Toggle(isClericClass, "Cleric Class");

        if (GUILayout.Button("Create"))
        {
            if (isWizardClass)
            {
                newPlayer.PlayerClass = new BaseWizard();
            }

            else if (isFighterClass)
            {
                newPlayer.PlayerClass = new BaseFighter();

            }

            else if(isRougeClass)
            {
                newPlayer.PlayerClass = new BaseRouge();
            }
            else if (isClericClass)
            {
                newPlayer.PlayerClass = new BaseCleric();
            }

            newPlayer.PlayerLevel = 1;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Dextarity = newPlayer.PlayerClass.Dextarity;
            newPlayer.Constitution = newPlayer.PlayerClass.Constitution;
            newPlayer.Intelegence = newPlayer.PlayerClass.Intelegence;
            newPlayer.Wisdom = newPlayer.PlayerClass.Wisdom;
            newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
            newPlayer.PlayerName = playerName;

            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("player Class: " + newPlayer.PlayerClass.CharacterClassNames);
            Debug.Log("player Level: " + newPlayer.PlayerLevel);
            Debug.Log("player Con: " + newPlayer.PlayerClass.Constitution);

        }
    }
}
