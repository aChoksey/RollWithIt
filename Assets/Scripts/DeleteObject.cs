using UnityEngine;
using System.Collections.Generic;

public class DeleteObject : MonoBehaviour
{
    public Stack<GameObject> placedObjects;

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
