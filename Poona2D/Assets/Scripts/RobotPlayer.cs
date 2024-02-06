using UnityEngine;
using System.Collections;

public class RobotPlayer : MonoBehaviour {
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

    public GameObject inputControllerObject;

    private IInputController inputController;

    void Start () {
        body = GetComponent<Rigidbody2D>();
		body.gravityScale = 2;
        inputController = inputControllerObject.GetComponent<IInputController>();
    }

    void Update() {

    }

    void FixedUpdate () {
        float xInput = inputController.GetXInput();
        if (body != null)
        {
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
        else
        {
            Debug.LogError("El GameObject no tiene un componente Rigidbody2D.");
        }
    }

}