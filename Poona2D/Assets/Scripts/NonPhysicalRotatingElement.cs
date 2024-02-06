using UnityEngine;
using System.Collections;

public class NonPhysicalRotatingElement : MonoBehaviour {
	public Transform characterTransform;
    public float currentRotation = 0;
    public float yInput = 0;

	float velocidadRotacion = 500;

	private Rigidbody2D rigidbodyObject;

	void Start () {
        transform.rotation =  Quaternion.Euler(0, 0, currentRotation);
		rigidbodyObject = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		yInput = Input.GetAxis("Vertical");
		if(yInput > 0) {
			currentRotation--;
			transform.rotation = Quaternion.Euler(0, 0, currentRotation);
		} else if (yInput < 0) {
			currentRotation++;
			transform.rotation = Quaternion.Euler(0, 0, currentRotation);
		}
	}
}
