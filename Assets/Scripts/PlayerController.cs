using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public float mouseSensitivity = 100f;
    public float walkSpeed = 5f;
    public AudioSource footAudioSource;
    public InputActionReference moveAction;

    private float currentSpeed;
    float gravity = -0.98f; 
    

    private void OnEnable()
    {
        moveAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
    }

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        currentSpeed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        ApplyGravity();
        Rotate();
       
    }

    void Move() 
    {
        float moveX = moveAction.action.ReadValue<Vector2>().x;
        float moveZ = moveAction.action.ReadValue<Vector2>().y;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        if (move.magnitude != 0)
        {
            if (!footAudioSource.isPlaying)
            {
                footAudioSource.Play();
            }
        }
        else footAudioSource.Stop();

        controller.Move(move * currentSpeed * Time.deltaTime);
    }

    void Rotate() 
    {
        float mouseX = Mouse.current.delta.x.ReadValue() * mouseSensitivity;
        transform.Rotate(Vector3.up * mouseX);
    }

    void ApplyGravity() 
    {
        bool isGrounded = controller.isGrounded;

        if (!isGrounded) 
        {
            controller.Move(Vector3.up * gravity);
        }
        else 
        {
            controller.Move(Vector3.up * -0.02f);
        }
    }
}
