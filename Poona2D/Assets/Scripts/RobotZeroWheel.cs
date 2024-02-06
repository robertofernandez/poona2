using UnityEngine;
using System.Collections;

public class RobotZeroWheel : MonoBehaviour {
	public Transform characterTransform;
    public float currentRotation = 0;

    public GameObject inputControllerObject;

    private IInputController inputController;

	void Start () {
        transform.rotation =  Quaternion.Euler(0, 0, currentRotation);
        inputController = inputControllerObject.GetComponent<IInputController>();
	}
	
	void Update () {
		float xInput = inputController.GetXInput();
        if (xInput > 0) {
            currentRotation--;
        } else if (xInput < 0) {
            currentRotation++;
        }

		transform.rotation = Quaternion.Euler(0, 0, currentRotation);
	}
}
