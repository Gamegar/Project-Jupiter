using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : BaseStatItem
{
    public enum EquipmentTypes
    {

        HELM,
        CHEST,
        SHOULDERS,
        WAIST,
        LEGS,
        FEET,
        HANDS
    }
    private EquipmentTypes equipmentType;

    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

}
