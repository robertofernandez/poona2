using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public Transform characterTransform;
    public float currentRotation = 0;
    //public float xInput = 0;
    public float yInput = 0;

	float velocidadRotacion = 500;

	private Rigidbody2D rigidbodyObject;

	void Start () {
        //transform.rotation =  Quaternion.Euler(0, 0, currentRotation);
		rigidbodyObject = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		/*
		yInput = Input.GetAxis("Vertical");
		if(yInput > 0) {
			currentRotation--;
			transform.rotation = Quaternion.Euler(0, 0, currentRotation);
		} else if (yInput < 0) {
			currentRotation++;
			transform.rotation = Quaternion.Euler(0, 0, currentRotation);
		}
		*/
       float inputRotation = Input.GetAxis("Vertical");

	   if(inputRotation == 0) 
	   {
		rigidbodyObject.constraints = RigidbodyConstraints2D.FreezeRotation;
	   } else
	   {
		rigidbodyObject.constraints = RigidbodyConstraints2D.None;
	   }

        // Calcular la velocidad angular basada en la entrada y la velocidad de rotación
        float velocidadAngular = inputRotation * velocidadRotacion;

        // Establecer la velocidad angular en el Rigidbody2D
        rigidbodyObject.angularVelocity = -velocidadAngular; // El signo negativo es para que la rotación sea en sentido horario
	}
}
