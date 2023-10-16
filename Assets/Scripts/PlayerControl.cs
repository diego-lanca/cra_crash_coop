using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float _speed = 20f;
    private float _turnSpeed = 45.0f;
    private float _horizontalInput, _forwardInput;
    public string inputID;
    
    public Camera mainCamera, driverCamera;
    public KeyCode switchKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Control which player moves
        _horizontalInput = Input.GetAxis("Horizontal" + inputID);
        _forwardInput = Input.GetAxis("Vertical" + inputID);
        
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);
        
        // Rotates the car
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);
        
        // Change the camera
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            driverCamera.enabled = !driverCamera.enabled;
        }
    }
}
