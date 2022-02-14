using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Meant to create the Canvas */
public class UIScriptPlayer : MonoBehaviour
{
    public Canvas prefabPlayerCanvas; //prefab
   // public GameObject HealthUI; //prefab

    //Instances 
    private Canvas playerCanvas;
    //private GameObject InstanceOfHealthUI;

    //List of different UI elements
    //Is obsolete if nothing is attached to the Canvas.
    private List<GameObject> uiElements;

    // Start is called before the first frame update
    void Start()
    {
        playerCanvas = Instantiate(prefabPlayerCanvas);
        uiElements = new List<GameObject>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    //Choice 2: Each gameplay component creates its own UI elements and has its own logic
    // ex. Health Component - creates UI object, knows where it needs to be on the screen
    //  (after creation -> the object is passed to a UI manager/ this script, gets attached)
    // => rest of the logic is controlled in the Health Component - pickup health, take damage, know how much health you have etc.
    //absolutely the same principle for supplies.
    // AttachUI() passes as parameters are the UI element (a prefab - which has already been initialized-),
    // then the location of where the prefab is placed on the screen 
    public void AttachUI(GameObject uiObject, Vector3 localPosition, Quaternion localRotation)
    {
        uiObject.transform.SetParent(playerCanvas.transform);
        uiObject.transform.localPosition = localPosition;
        uiObject.transform.localRotation = localRotation;
        uiElements.Add(uiObject);
    }

}