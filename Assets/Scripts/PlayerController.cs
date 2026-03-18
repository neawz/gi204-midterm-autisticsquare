using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private float forwardInput;
    private float horizontalInput;
    private Vector3 moveInput;
    private InputAction moveAction;
    void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        forwardInput = moveInput.y;
        horizontalInput = moveInput.x;
        transform.Translate(moveInput.y * moveSpeed * Time.deltaTime * Vector3.forward);
        transform.Translate(moveInput.x * moveSpeed * Time.deltaTime * Vector3.right);
    }
}
