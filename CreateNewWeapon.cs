using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour
{
    private BaseWeapon newWeapon;

    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.WeaponType.ToString() + newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log("Strength " + newWeapon.Strength);
        Debug.Log("Dextarity " + newWeapon.Dextarity);
        Debug.Log("Constitution " + newWeapon.Constitution);
        Debug.Log("Intelegence " + newWeapon.Intelegence);
        Debug.Log("Wisdom " + newWeapon.Wisdom);
        Debug.Log("Charisma " + newWeapon.Charisma);
        Debug.Log("Attack bonuse "+newWeapon.AttackBonuse);
    }

    public void CreateWeapon()
    {

        newWeapon = new BaseWeapon();
       
       

        //description
        newWeapon.ItemDescription = "This is a new weapon";
        //id 
        newWeapon.ItemID = Random.Range(1,101);
        //stats 
        newWeapon.Constitution = Random.Range(1,11);
        newWeapon.Strength = Random.Range(1,11);
        newWeapon.Intelegence = Random.Range(1,11);
        newWeapon.Dextarity = Random.Range(1,11);
        newWeapon.Charisma = Random.Range(1,11);
        newWeapon.Wisdom = Random.Range(1,11);
        newWeapon.AttackBonuse = Random.Range(5,20);
        

    }
    // type
    private void ChooseWeaponType() { 

    int randomTemp = Random.Range(1,6);

    if (randomTemp == 1){
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
        }
       else  if (randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
        }
       else  if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
        }
       else if  (randomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.MACE;
        }

        else if (randomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        }
    }
 //give name
    private void WeaponNames()
    {

        int randomName = Random.Range(1, 6);

        if (randomName == 1)
        {
            newWeapon.ItemName = " of Thor";
        }
        else if (randomName == 2)
        {
            newWeapon.ItemName = " of Jupiter";
        }
        else if (randomName == 3)
        {
            newWeapon.ItemName = " of Zuse";
        }
        else if (randomName == 4)
        {
            newWeapon.ItemName = " of Ra";
        }

        else if (randomName == 5)
        {
            newWeapon.ItemName = " of Odin";
        }
    }


}
