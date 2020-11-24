using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;  //
    public Image image; //referencia al objeto que va mostrar

    private Inventory inventory;


    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory == null)
        {
            return;
        }

        if(item != null)
        {
            image.sprite = item.icon;
        }
    }

    public void SetItem(Item item) // metodo para agregar la imagen al menu
    {
        this.item = item;
         image.sprite = item.icon;
         image.enabled = true;
    }

    public void Clear() //metodo para remover el imagen del menu
    {
        this.item = null;
         image.sprite = null;
         image.enabled = false;
    }

    public void RemoveFromInventory()
    {
        if(this.item != null)
        {
            inventory.Remove(item);
        }

    
    }

    public void UseItem()
        {
            if(item != null)
            {
                item.Use();
                RemoveFromInventory();
            }
        }
}
