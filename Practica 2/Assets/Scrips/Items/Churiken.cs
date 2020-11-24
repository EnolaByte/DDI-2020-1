using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nuevo Churiken", menuName = "Inventario/Wepon/Churiken")]
public class Churiken : Item
{

    public float vel = 33.5f;
    public float damage = 15.4f;


  public override void Use()
  {
      Debug.Log("Se uso la:"+name+ "\nSu daño es de:"+ damage + "\nSu velocidad es:"+vel);
  }
}
