using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElementCombiner : MonoBehaviour
{
    public GameObject newElement;

    private void Start()
    {
        newElement.GetComponent<SpriteRenderer>().enabled = false;
    }
    
    public void CombineElements(GameObject element1, GameObject element2)
    {
        Destroy(element1);
        Destroy(element2);

        if ((element1.name == "Haroonium" && element2.name == "Declanite") || (element1.name == "Declanite" && element2.name == "Haroonium"))
        {
            Instantiate(newElement, new Vector3(0, 0, 0), transform.rotation);
            newElement.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            Debug.Log("poof");
        }
    
    
    }
}