using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public Transform characterTransform;
    public float currentRotation = 0;

    public float yInput = 0;

	float velocidadRotacion = 500;

	private Rigidbody2D rigidbodyObject;

    public GameObject inputControllerObject;

    private IInputController inputController;


	void Start () {
		rigidbodyObject = GetComponent<Rigidbody2D>();
		inputController = inputControllerObject.GetComponent<IInputController>();
	}
	
	void Update () {
       float inputRotation = inputController.GetYInput();

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
