using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nuevo Bomba", menuName = "Inventario/Wepon/Bomba")]
public class Bomba : Item
{
    
    public float damage = 55.2f;
    

    public override void Use()
   {
       Debug.Log("Se utilizo el:" + name + "\nsu daño es"+damage);
   }
}
