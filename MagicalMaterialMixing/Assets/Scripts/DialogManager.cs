using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using System.IO;


public class DialogManager : MonoBehaviour
{
    private string s;
    public TextMeshProUGUI Dialog;
    private StreamReader sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Dialog.text =

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Dialog1_1")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog.txt");
            Dialog.text = "--You enter your uncle's garage.--";
        }
        else if (scene.name == "Dialog1_2")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog1_2.txt");
            Dialog.text = "Oh, it looks like I made Harlanite!";
        }
        else if (scene.name == "Dialog1_3")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog1_3.txt");
            Dialog.text = "--You successfully concoct Harlanite.--";
        }
        else if (scene.name == "Dialog2_1")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog2_1.txt");
            Dialog.text = "--The garage door opens again.--";
        }
        else if (scene.name == "Dialog2_2")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog2_2.txt");
            Dialog.text = "--You made some Decstone.--";
        }
        else if (scene.name == "Dialog3_1")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog3_1.txt");
            Dialog.text = "--Yet again, the garage door opens.--";
        }
        else if (scene.name == "Dialog3_2")
        {
            sr = File.OpenText("..\\MagicalMaterialMixing\\Assets\\Scripts\\dialog3_2.txt");
            Dialog.text = "--You demonstrate the creation of Joylerian to Jack.--";
        }

    }

    // Update is called once per frame
    // "C:\Users\Joy\Documents\GitHub\Magic-Material-Mixing\MagicalMaterialMixing\Assets\Scripts\dialog.txt"
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Click");
            
            if ((s = sr.ReadLine()) != null)
            {
                Dialog.text = s;
            }
            else
            {
                SceneManager.LoadScene("ExploreScene");
            }
            
        }
    }

}
