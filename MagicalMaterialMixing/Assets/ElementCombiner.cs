using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElementCombiner : MonoBehaviour
{
    public GameObject newElement;
    
    public void CombineElements(GameObject element1, GameObject element2)
    {
        if((element1.name == "Haroonium" && element2.name == "Declanite") || (element1.name == "Declanite" && element2.name == "Haroonium"))
        {
            Destroy(element1);
            Destroy(element2);
            Instantiate(newElement, new Vector3(0, 0, -0.1f), transform.rotation);
        } else
        {
            SceneManager.LoadScene("ExploreDeath");
        }

        
    }
}