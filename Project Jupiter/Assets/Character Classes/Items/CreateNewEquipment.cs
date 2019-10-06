using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour
{

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common ", "Rare ", "Very Rare ", "Legendary " };
    private string[] itemDesc = new string[2] { "Basic item", "interesting item" };

    // Start is called before the first frame update
    void Start()
    {
        CreateEquipment();
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.EquipmentType.ToString());
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log("Strength " + newEquipment.Strength);
        Debug.Log("Dextarity " + newEquipment.Dextarity);
        Debug.Log("Constitution " + newEquipment.Constitution);
        Debug.Log("Intelegence " + newEquipment.Intelegence);
        Debug.Log("Wisdom " + newEquipment.Wisdom);
        Debug.Log("Charisma " + newEquipment.Charisma);
        
    }

         private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + "Item";
        newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemType();
        newEquipment.ItemDescription = itemDesc[Random.Range(0, itemDesc.Length)];
        newEquipment.Constitution = Random.Range(0, 11);
        newEquipment.Strength = Random.Range(0, 11);
        newEquipment.Intelegence = Random.Range(0, 11);
        newEquipment.Dextarity = Random.Range(0, 11);
        newEquipment.Charisma = Random.Range(0, 11);
        newEquipment.Wisdom = Random.Range(0, 11);
    }
    private void ChooseItemType()
    {
        

        int randomTemp = Random.Range(1, 8);

        if (randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HELM;
        }
        else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;     
                }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;     
                }
        else if (randomTemp == 4)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
        }

        else if (randomTemp == 5)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.WAIST;
        }
        else if (randomTemp == 6)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
        }
        else if (randomTemp == 7)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
