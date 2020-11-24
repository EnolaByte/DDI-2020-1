using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnChange();
    public OnChange onChange;      //deleados para hacer cambios en inventarios e inventoryUI


    
	public int space = 28;
    public List<Item> items = new List<Item>(); //recolectamos una lista de objetos 

    public void Add(Item item)
    {
        if(items.Count < space)
        {
            items.Add(item);
            if(onChange != null)
            {
                onChange.Invoke();
            }
        }
        else
        {
            Debug.LogWarning("Espacio Insuficiente!");
        }


    }

    public void Remove(Item item)
    {
        if(items.Contains(item))
        {
            items.Remove(item);
            if(onChange != null)
            {
                onChange.Invoke();
            }
        }
        else
        {
            Debug.LogWarning("Item no esta en el inventario");
        }
    }
}
