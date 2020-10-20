using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
	// Variables para gestionar el radio de vision y velocidad del enemigo

	public float visionRadius;
	public float speed;
	
	//Variable para guardar al jugador 
	GameObject player;
	
	//Variable para guardar la posicion inicial 
	Vector3 initialPosition;
	
    // Start is called before the first frame update
    void Start()
    {
    // Recuperamos al jugador mediante un TAG
        player = GameObject.FindGameObjectWithTag("Player");
        
        // Guardamos la posicion incial del enemigo
        initialPosition = transform.position;
    }


    void Update()
    {
        // por defecto nuestro objeto siempre sera nuestra poscion inicial
        Vector3 target = initialPosition;
        
        //pero si la distancia hasta el jugador es menor que el radio de vision el objetivo sera el 
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadius) target = player.transform.position;
        
        // finalmente movemos al enemigo en distancia a su target 
        float fixedSpeed = speed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);
        
        // debug con una linea
        Debug.DrawLine(transform.position, target, Color.red);
        
    }
    
    void OnDrawGizmos()
    {
    	Gizmos.color = Color.green;
    	Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}
