using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour {

    private MeshRenderer Rend;
    public Vector3 Positions;
    private GameObject Tower;
    [SerializeField]
    private Color HoveColor;
    private Color NewColor;
    private void Start()
    {
        Rend = GetComponent<MeshRenderer>();
        NewColor = Rend.material.color;
    }
    private void OnMouseDown()
    {
        if (Tower != null)
        {
            Debug.Log("Can't build here");
            return;
        }
        GameObject turettobuild = BuilderManeger.instance.ToBuild();
        Tower = (GameObject)Instantiate(turettobuild, transform.position + Positions, transform.rotation);

    }
    private void OnMouseEnter()
    {
        Rend.material.color = HoveColor;
    }
    private void OnMouseExit()
    {
        Rend.material.color = NewColor;
    }
}
