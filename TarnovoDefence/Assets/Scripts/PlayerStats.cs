using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public static int Health = 20;
    private static int Money = 400;
    public static void ModifyHealth(int Value)
    {
        if (Health - Value < 0)
        {
            Lose();
        }
        else
        {
            Health += Value;
        }
    }
    public static bool ModifyMoney(int Value)
    {
        Money += Value;
        if (Money + Value > 0)
        {
            Money += Value;
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Lose()
    {
        Debug.Log("Game Over");
    }
}
