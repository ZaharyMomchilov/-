using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public static NewBehaviourScript instance;
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

    public GameObject zastoene()
    {
        return kulazastroene;
    }
}
