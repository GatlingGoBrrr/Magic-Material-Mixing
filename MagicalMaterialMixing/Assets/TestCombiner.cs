using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestCombiner : MonoBehaviour
{
    public GameObject newElement;

    private void Start()
    {
        newElement.GetComponent<SpriteRenderer>().enabled = false;
    }
    IEnumerator Wait(float duration)
    {
        yield return new WaitForSeconds(duration);
    }

    public void CombineElements(GameObject element1, GameObject element2)
    {
        Destroy(element1);
        Destroy(element2);

        if ((element1.name == "Haroonium" && element2.name == "Declanite") || (element1.name == "Declanite" && element2.name == "Haroonium"))
        {
            Instantiate(newElement, new Vector3(0, 0, 0), transform.rotation);
            newElement.GetComponent<SpriteRenderer>().enabled = true;
            Wait(5f);
            SceneManager.LoadScene("Dialog1_3");

        }
        else
        {
            SceneManager.LoadScene("Death");
        }
    
    
    }
}