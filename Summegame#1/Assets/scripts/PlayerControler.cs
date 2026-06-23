using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerControler : MonoBehaviour
{
     [SerializeField] private InputActionAsset InputActions;   

    private InputAction moveAction;
    private InputAction jumpAction;

    private Vector2 moveInput; 
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float 
    //Theses are the componets
    [SerializeField] private Rigidbody rb; 

    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private float  jumpForce =5f;
    //Awake is like the "reboot"
    private void Awake()
       {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        rb = GetComponent<Rigidbody>();
       }
       

       private void OnEnable()
       {
        InputActions.FindActionMap("Player").Enable();
       }
       private void OnDisable()
      {
        InputActions.FindActionMap("Player").Disable();
      }
      //update is known as once per frame whih is between 60 and 120 frames per second, or "FPS"
      private void Update()
      {
       moveInput = moveAction.ReadValue<Vector2>();//this stores the movment after it's read.
        if (jumpAction.WasPressedThisFrame())
        {
            //this telles the game the player is jumping and how many times
           HandleJump();
        }

      }

      private void FixedUpdate()
      {
         HandleMovement();
      }
       

       private void HandleMovement()
       {
       Vector3 moveDirection = transform.forward * moveInput.y + transform.right * moveInput.x;

       rb.MovePosition(rb.position+ moveDirection * moveSpeed * Time.deltaTime);      
       }

       
       private void HandleJump()
       if (IsGrounded())
       {
        
        rb.AddForce( Vector3.up * jumpForce, ForceMode. Impulse);
     
       }
    private bool IsGrounded()
    {
        return Physics.Raycast(transoform.position, Vector3.down, groundCheckDistance, groundLayer);
    Debug.DrawRay(
        transform.position, Vector3.down * groundCheckDistance
    );
    }
}
