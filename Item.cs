using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="New Item",menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool showInventory = true;

    //คำสั่งกรณีใช้ Item
    public void Use()
    {
        if(name.Equals("Axe"))
        {
           Hassanmovement.instance.ShowAxe();
           RemoveItemFromInventory();
        }
        if(name.Equals("Chicken"))
        {
            Foodcontroiler.instance.healingFood();
            RemoveItemFromInventory();
        }
    }
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(this);
    }

}
