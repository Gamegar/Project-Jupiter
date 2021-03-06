﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem
{

    public enum WeaponTypes {

        SWORD,
        MACE,
        DAGGER,
        STAFF,
        SHIELD
    }

    private WeaponTypes weaponType;


    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value;  }
    }
    
}
