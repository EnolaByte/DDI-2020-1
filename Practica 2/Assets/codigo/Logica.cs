using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

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

    private void FixedUpdate() {
        transform.Rotate(0, x * Time.deltaTime * velocidad_rotacion,0);
        transform.Translate(0, 0 , y* Time.deltaTime * velocidad_movimiento);
    }
    // Update is called once per frame
    void Update()
    {
        x = CrossPlatformInputManager.GetAxis("Horizontal");
        y = CrossPlatformInputManager.GetAxis("Vertical");
        
        
        anim.SetFloat("velX",x);
        anim.SetFloat("velY",y);
    }
}
