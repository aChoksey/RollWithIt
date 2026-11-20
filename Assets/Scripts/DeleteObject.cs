using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class DeleteObject : MonoBehaviour
{
    private Stack<GameObject> placedObjects = new Stack<GameObject>();

    public void Update()
    {
        if (Keyboard.current.uKey.wasPressedThisFrame)
        {
            DeleteFromStack();
        }
    }

    public void AddToStack(GameObject obj)
    {
        placedObjects.Push(obj);
    }

    public void DeleteFromStack()
    {
        if (placedObjects.Count > 0)
        {
            GameObject deletedObject = placedObjects.Pop();
            Destroy(deletedObject);
        }
    }
    

}
