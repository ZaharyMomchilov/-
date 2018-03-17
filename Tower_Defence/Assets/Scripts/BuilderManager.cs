using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderManager : MonoBehaviour
{

    public static BuilderManager instance;
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


