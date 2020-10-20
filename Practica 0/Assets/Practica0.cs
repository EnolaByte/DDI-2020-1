using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int [] input={1,2,3,4};   //Declaro vectores
      int [] output= new int[4]; 

        sumaElem(input,output);  //funcion que calcula la suma de elementos
    }
    
    void sumaElem(int [] vectorEntrada, int [] vectorSalida)
    {
         
        int j=0;
        int i;
        
        for(i=0;i<4;i++){
         j= vectorEntrada[i] + j;  //suma de elementos
         vectorSalida[i]=j;
        }
       
        Debug.Log("Input: [" +vectorEntrada[0]+","+vectorEntrada[1]+","+vectorEntrada[2]+","+vectorEntrada[3]+"]");  //impresion
        Debug.Log("Output: ["+vectorSalida[0]+","+vectorSalida[1]+","+vectorSalida[2]+","+vectorSalida[3]+"]");
    }
}
