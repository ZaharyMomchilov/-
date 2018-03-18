using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderManeger : MonoBehaviour {
    public static BuilderManeger instance;
    private int cost = 100;
    private void Awake()
    {
        instance = this;
    }
    private GameObject TuretToBuild;
    private void Start()
    {
        TuretToBuild = PlayerPrefab;
    }

    public GameObject PlayerPrefab;

    public GameObject ToBuild()
    {
        return TuretToBuild;
    }
}
