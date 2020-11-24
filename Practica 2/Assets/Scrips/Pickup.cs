using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interactable
{
    private Inventory inventory; //objeto de tipo inventario
    public Item item;              //item
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();//buscamos el objeto inventario
        if(inventory == null)//verificamos que no este vacio
        {
            Debug.LogWarning("No se encontro el inventario"); //mensaje de erro si no existe
        }
    }


   public override void Interact() //heredamos el metodo interact
   {
       Debug.Log("Levantando Item");//verificamos que se levanto un item
       inventory.Add(item); //agregamos un item a el inventario
       Destroy(gameObject); //destruimos el objeto teniento una referencia de el 
   }
}
