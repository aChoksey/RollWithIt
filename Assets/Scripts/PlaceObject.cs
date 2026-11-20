using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class PlaceObject : MonoBehaviour
{
    public GameObject currentObject;
    public GameObject blockObject;
    public GameObject trampolineObject;
    public GameObject rampObject;
    public DeleteObject objectStack;
    
    private Vector2  screenPosition;
    private Vector2 mousePosition;
    private int[] shapesArray =  new int[GameParameters.numShapesAvailable];
    private int shapeIndex = 0;
    

    public void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject placed = Place(currentObject);
            objectStack.AddToStack(placed);
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            CycleThroughShapesArray();
        }
    }

    private void CycleThroughShapesArray()
    {
        shapeIndex = (shapeIndex + 1) % GameParameters.numShapesAvailable;
        SwitchCurrentObject();
    }

    private void SwitchCurrentObject()
    {
        if (shapeIndex == 0)
        {
            currentObject = blockObject;
        }
        else if (shapeIndex == 1)
        {
            currentObject = trampolineObject;
        }
        else if (shapeIndex == 2)
        {
            currentObject = rampObject;
        }
    }

    private GameObject Place(GameObject currentObject)
    {
        //print("Placed " + currentObject);
        screenPosition = Mouse.current.position.ReadValue();
        mousePosition = Camera.main.ScreenToWorldPoint(screenPosition);
        GameObject placed = Instantiate(currentObject, mousePosition, Quaternion.identity);

        return placed;
    }
    //method on click
        //pick a point on screen
        //create object at that point
        
    //use arrow keys to cycle though objects
        //store object names in array and move through
        //current object = array slot object
        
    
}
