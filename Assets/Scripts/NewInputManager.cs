using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
	private PlayerInputActions inputActions;
	public float moveSpeed = 5f;
	private Rigidbody rb;

	private bool moveForward; 
	private bool moveBackward;

	void Awake()
	{
		inputActions = new PlayerInputActions();
	}

	void OnEnable()
	{
		inputActions.Player.Enable();

		inputActions.Player.MoveForward.performed += ctx => moveForward = true;
		inputActions.Player.MoveForward.canceled += ctx => moveForward = false;

		inputActions.Player.MoveBack.performed += ctx => moveBackward = true;
		inputActions.Player.MoveBack.canceled += ctx => moveBackward = false;
	}

	void OnDisable()
	{
		inputActions.Player.Disable();
	}

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		if (moveForward)
		{
			rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		}
		if (moveBackward)
		{
			rb.MovePosition(transform.position - transform.forward * moveSpeed * Time.fixedDeltaTime);
		}
	}
}
