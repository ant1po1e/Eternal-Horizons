using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than 1 instance of Inventory found!");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChange();
    public OnItemChange onItemChangeCallback;

    public int space = 20;
    public List<Item> items = new List<Item>();
    

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room");
                return false;
            }

            items.Add(item);

            if (onItemChangeCallback != null)
                onItemChangeCallback.Invoke();
        }

        return true;
    }


    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangeCallback != null)
            onItemChangeCallback.Invoke();
    }
}
