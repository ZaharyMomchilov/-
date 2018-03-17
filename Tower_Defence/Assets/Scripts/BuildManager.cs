using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager: MonoBehaviour
{

    public static BuildManager instance;
    private void Awake()
    {
        instance = this;
    }
    private GameObject kulazastroene;
    private void Start()
    {
        kulazastroene = PlayerPrefab;
    }

    public GameObject PlayerPrefab;

    public GameObject Zastoene()
    {
        return kulazastroene;
    }
}