using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nudes : MonoBehaviour {
    private MeshRenderer rend;

    private GameObject kula;
    
    public Color HoveColor;
    private Color nColor;
    private void Start()
    {
        rend = GetComponent<MeshRenderer>();
        nColor = rend.material.color;
    }
    private void OnMouseDown()
    {
        if(kula != null)
        {
            Debug.Log("Не ствава брат");
            return;
        }
        GameObject kulazastroene = NewBehaviourScript.instance.zastoene();
        kula = (GameObject)Instantiate(kulazastroene, transform.position, transform.rotation);
          
    }
    private void OnMouseEnter()
    {
        rend.material.color = HoveColor;
    }
    private void OnMouseExit()
    {
        rend.material.color = nColor;
    }
}

