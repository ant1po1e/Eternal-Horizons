using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        Pickup();
    }

    void Pickup()
    {
        Debug.Log("Picking up an Item " + item.name);
        bool isPickedUp = Inventory.instance.Add(item);

        if (isPickedUp)
            Destroy(gameObject);
    }

}
