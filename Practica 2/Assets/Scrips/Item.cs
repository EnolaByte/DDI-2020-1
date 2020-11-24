using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType //clase de tipo enum para asignar un tipo al objeto 
{
    Wepon,

    Magic,

    Vida
}    


[CreateAssetMenu(fileName = "Nuevo Item", menuName = "Inventario/GenericItem")]
public class Item : ScriptableObject {
    

    
   public Sprite icon = null; //variable para guardar el sprite

   public ItemType itemType = ItemType.Wepon; //llamamos un tipo de la lista

   public virtual void Use() //metodo par utilizar el objeto
   {
       Debug.Log("Usando item: " + name);

   }
}
