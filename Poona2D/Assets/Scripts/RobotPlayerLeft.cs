using UnityEngine;
using System.Collections;

public class RobotPlayerLeft : MonoBehaviour {
    private Rigidbody2D body;

    public float maxVelocityY = 10;
    public float maxVelocityX = 10;
    public float baseJumpVelocity = 8;
    public float jumpVelocityMultiplier = 0.4f;
    public float xVelocityIncreaseRate = 0.4f;
    public float xVelocityDecreaseRate = 0.8f;
    public float yVelocityIncreaseRate = 0.4f;

    public float currentVelocityX = 0;
    public float currentVelocityY = 0;

    void Start () {
        body = GetComponent<Rigidbody2D>();
		body.gravityScale = 2;
    }

    void Update() {

    }

    void FixedUpdate () {

        float xInput = 0f;
        if (Input.GetKey(KeyCode.A)) {
            xInput = -1f;
        } else if (Input.GetKey(KeyCode.D)) {
            xInput = 1f;
        }

        
        if (body != null)
        {

        }
        else
        {
            Debug.LogError("El GameObject no tiene un componente Rigidbody2D.");
        }

        xInput = Input.GetAxis("Horizontal");
        if (xInput > 0 && currentVelocityX < maxVelocityX) {
            if (currentVelocityX < 0) {
                currentVelocityX = currentVelocityX + Mathf.Max(xVelocityIncreaseRate, xVelocityDecreaseRate);
            } else {
                currentVelocityX = currentVelocityX + xVelocityIncreaseRate;
            }
        } else if (xInput < 0 && currentVelocityX > (-1 * maxVelocityX)) {
            if (currentVelocityX > 0) {
                currentVelocityX = currentVelocityX - Mathf.Max(xVelocityIncreaseRate, xVelocityDecreaseRate);
            } else {
                currentVelocityX = currentVelocityX - xVelocityIncreaseRate;
            }
        } else if (xInput == 0 && currentVelocityX > 0) {
            currentVelocityX = Mathf.Max(0, currentVelocityX - xVelocityDecreaseRate);
        } else if (xInput == 0 && currentVelocityX < 0) {
            currentVelocityX = Mathf.Min(0, currentVelocityX + xVelocityDecreaseRate);
        }

        body.velocity = new Vector2(currentVelocityX , currentVelocityY);
    }

}