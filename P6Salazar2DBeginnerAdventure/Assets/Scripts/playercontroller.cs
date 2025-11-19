using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem
    ;
public class playercontroller : MonoBehaviour
{    public InputAction leftaction;
    public InputAction moveraction;
    private Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
        leftaction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = moveraction.ReadValue<Vector2>();
        Debug.Log(move);
        
        Vector2 position =(Vector2) transform.position + move * speed * Time.deltaTime;
       
        transform.position = position;
    }
}
