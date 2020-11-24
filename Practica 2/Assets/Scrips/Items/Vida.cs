using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Vida", menuName = "Inventario/Vida/vida")]
public class Vida : Item
{
    public int porcetaje = 100;

    public override void Use()
    {
        Debug.Log("Se utilizo el item:" + name + "\nSe curo el porcentaje:"+porcetaje);
    }
}
