using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static string PlayerName{ get; set; }
    public static string PlayerLevel { get; set; }
    public static Baseclass PlayerClass { get; set; }
    public static int Strength { get; set; }
    public static int Dextarity { get; set; }
    public static int Constitution { get; set; }
    public static int Intelegence { get; set; }
    public static int Wisdom { get; set; }
    public static int Charisma { get; set; }
}
