using UnityEngine;
using System.Collections;

public class RobotZeroWheel : MonoBehaviour {
	public Transform characterTransform;
    public float currentRotation = 0;

	void Start () {
        transform.rotation =  Quaternion.Euler(0, 0, currentRotation);
	}
	
	void Update () {
		float xInput = Input.GetAxis("Horizontal");
        if (xInput > 0) {
            currentRotation--;
        } else if (xInput < 0) {
            currentRotation++;
        }

		transform.rotation = Quaternion.Euler(0, 0, currentRotation);
	}
}
