using UnityEngine;
using System.Collections;

public class NetBot : MonoBehaviour {
	private Rigidbody2D rigidbodyObject;

	public int timesStaying = 0;
	private float lastY = -1000;

	public bool frozen = false;

	void Start () {
		rigidbodyObject = GetComponent<Rigidbody2D>();
		timesStaying = 0;
	}
	
	void Update () {
		if(frozen) {
			return;
		}

		if(transform.position.y == lastY) {
			timesStaying++;
		} else {
			timesStaying = 0;
			lastY = transform.position.y;
		}
		if(timesStaying > 20) {
			frozen = true;
			rigidbodyObject.constraints = RigidbodyConstraints2D.FreezePosition | RigidbodyConstraints2D.FreezeRotation;
			return;
    	}
	}
}
