using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nuevo Chiken Wing", menuName = "Inventario/Vida/Chiken Wing")]
public class ChikenWing : Item
{
  
   public float curacion = 100.0f;
  

   public override void Use()
   {
       Debug.Log("Se utilizo la: " + name + "\n Su curacion es de:" + curacion);
   }
}
