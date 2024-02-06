using UnityEngine;
using System.Collections;
public class AsdwAxisInputController : MonoBehaviour, IInputController
{
    public float GetXInput()
    {
        float xInput = 0f;
        if (Input.GetKey(KeyCode.A)) {
            xInput = -1f;
        } else if (Input.GetKey(KeyCode.D)) {
            xInput = 1f;
        }
        return xInput;
    }

    public float GetYInput()
    {
       float inputRotation = 0f;
        if (Input.GetKey(KeyCode.S)) {
            inputRotation = -1f;
        } else if (Input.GetKey(KeyCode.W)) {
            inputRotation = 1f;
        }
        return inputRotation;
    }

    void Start()
    {
        // Initialization logic
    }

    void Update()
    {
        // Your MonoBehaviour Update logic
    }
}