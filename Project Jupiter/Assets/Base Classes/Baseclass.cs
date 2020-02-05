using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseclass : MonoBehaviour
{
    public string TheName;
    public float curHP;
    public float baseHP;

    
    public float baseMP;
    public float curMP;
    public int BaseAttack;
    public int Curattack;
    public float BaseDefence;
    public float CurDefence;

    public List<BaseAttack> attacks = new List<BaseAttack>(); 
   
}
