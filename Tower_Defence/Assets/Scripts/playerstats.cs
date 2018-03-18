using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerstats : MonoBehaviour {


    public  int kruv;
    public int startkruv = 20;


    public int Money;
    public int startMoney = 20;
    public void Awake()
    {
        kruv = startkruv;
        Money = startMoney;
        
    }
}
