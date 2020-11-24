using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InventoryUI : MonoBehaviour
{
	public GameObject Menu;
    private Inventory inventory;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory == null)
        {
            return;
        }
        Menu.SetActive(false);
        inventory.onChange += UpdateUI; //actualiza inventario
    }


    void Update()
    {
        //Input.GetKeyDown(KeyCode.I)
        //CrossPlatformInputManager.GetButtonDown("Fire2")
        if(Input.GetKeyDown(KeyCode.Q))
        {
        	Menu.SetActive(!Menu.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI() //vamos a recorrer la lista de objetos y vamos a asignar a cada slot la imagen
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        for(int i = 0; i<slots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
            slots[i].SetItem(inventory.items[i]);
            }else
            {
                slots[i].Clear();
            }
        }
    }
}
