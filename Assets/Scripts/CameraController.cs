using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float mouseSensitivity = 10f;
    public float maxAngle = 90; 
    public float minAngle = 90; 

    float rotationX = 0f;

    public bool stopRotation = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rotationX = transform.localRotation.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stopRotation)
            Rotate();
    }

    void Rotate() 
    {
        float mouseY = Mouse.current.delta.y.ReadValue() * mouseSensitivity;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, minAngle, maxAngle);
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
