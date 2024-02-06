using UnityEngine;
using System.Collections;

public class DefaultAxisInputController : MonoBehaviour, IInputController
{
    public float GetXInput()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetYInput()
    {
        return Input.GetAxis("Vertical");
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