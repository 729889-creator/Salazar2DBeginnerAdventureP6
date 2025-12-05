using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
        MoveAction.Enable(); // Fix: Add parentheses to call Enable() method
        Vector3 position = transform.position; // Fix: Use Vector3 instead of Vector2
        position.x = position.x + 0.1f;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + 0.1f * move * Time.deltaTime; // UNT0024: Re-order operands for better performance
        Debug.Log(move);
        position = (Vector2)transform.position + 0.1f * move; // UNT0024: Re-order operands for better performance
        transform.position = position;
        float horizontal = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }

        Debug.Log(horizontal);

        Vector2 tempPosition = transform.position; // Fix: Use a different variable name to avoid redeclaration
        tempPosition.x = tempPosition.x + 0.1f;
        transform.position = tempPosition;
    }
}