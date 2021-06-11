using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    public float horizontalInput;
    public float forwardInput;

    public bool grounded;

    public static PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = this;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        
        Move();        

        // This is where we get player input for to switch camera view
        if (Input.GetButtonDown("Jump") && SceneManager.GetActiveScene().buildIndex == 2)
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }

    void ReadInput()
    {
        // This is where we get player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    }
    
    void Move()
    {
        // We move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
