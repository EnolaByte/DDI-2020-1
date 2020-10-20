using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica : MonoBehaviour
{
	public float velocidad_movimiento =  5.0f;
	public float velocidad_rotacion = 200.0f;
	private Animator anim;
	public float x,y;
	

    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
      
        	
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        
        transform.Rotate(0, x * Time.deltaTime * velocidad_rotacion,0);
        transform.Translate(0, 0 , y* Time.deltaTime * velocidad_movimiento);
        
        anim.SetFloat("velX",x);
        anim.SetFloat("velY",y);
    }
}
