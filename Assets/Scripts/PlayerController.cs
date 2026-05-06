using UnityEngine;
using UnityEngine.InputSystem;

namespace MtdDemo.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float runSpeed = 10f;
        [SerializeField] private Transform cameraRoot;
        [SerializeField] private float mouseLookSensitivity = 0.1f;
        [SerializeField] private float gamepadLookSensitivity = 120f;
        [SerializeField] private float gravity = -20f;
        [SerializeField] private bool lockCursorOnStart = true;

        private CharacterController _characterController;
        private InputAction _moveAction;
        private InputAction _lookAction;
        private InputAction _runAction;
        private float _pitch;
        private float _verticalVelocity;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            if (cameraRoot == null && Camera.main != null)
            {
                cameraRoot = Camera.main.transform;
            }

            _moveAction = new InputAction("Move", InputActionType.Value);
            _moveAction.AddCompositeBinding("2DVector")
                .With("Up", "<Keyboard>/w")
                .With("Down", "<Keyboard>/s")
                .With("Left", "<Keyboard>/a")
                .With("Right", "<Keyboard>/d");

            _moveAction.AddCompositeBinding("2DVector")
                .With("Up", "<Keyboard>/upArrow")
                .With("Down", "<Keyboard>/downArrow")
                .With("Left", "<Keyboard>/leftArrow")
                .With("Right", "<Keyboard>/rightArrow");

            _moveAction.AddBinding("<Gamepad>/leftStick");

            _lookAction = new InputAction("Look", InputActionType.Value);
            _lookAction.AddBinding("<Mouse>/delta");
            _lookAction.AddBinding("<Gamepad>/rightStick");

            _runAction = new InputAction("Run", InputActionType.Button);
            _runAction.AddBinding("<Keyboard>/leftShift");
            _runAction.AddBinding("<Keyboard>/rightShift");
            _runAction.AddBinding("<Gamepad>/leftStickPress");
        }

        private void OnEnable()
        {
            _moveAction.Enable();
            _lookAction.Enable();
            _runAction.Enable();

            if (lockCursorOnStart)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        private void OnDisable()
        {
            _moveAction.Disable();
            _lookAction.Disable();
            _runAction.Disable();
        }

        private void OnDestroy()
        {
            _moveAction.Dispose();
            _lookAction.Dispose();
            _runAction.Dispose();
        }

        private void Update()
        {
            HandleLook();
            HandleMove();
        }

        private void HandleMove()
        {
            Vector2 moveInput = _moveAction.ReadValue<Vector2>();
            float currentSpeed = _runAction.IsPressed() ? runSpeed : moveSpeed;
            Vector3 horizontalMove = (transform.right * moveInput.x + transform.forward * moveInput.y) * currentSpeed;

            if (_characterController.isGrounded && _verticalVelocity < 0f)
            {
                _verticalVelocity = -2f;
            }

            _verticalVelocity += gravity * Time.deltaTime;
            Vector3 move = horizontalMove + Vector3.up * _verticalVelocity;

            _characterController.Move(move * Time.deltaTime);
        }

        private void HandleLook()
        {
            Vector2 lookInput = _lookAction.ReadValue<Vector2>();
            bool usingMouse = Mouse.current != null && Mouse.current.delta.ReadValue().sqrMagnitude > 0f;
            float lookScale = usingMouse ? mouseLookSensitivity : gamepadLookSensitivity * Time.deltaTime;

            float yawDelta = lookInput.x * lookScale;
            float pitchDelta = lookInput.y * lookScale;

            transform.Rotate(Vector3.up * yawDelta);

            if (cameraRoot == null)
            {
                return;
            }

            _pitch = Mathf.Clamp(_pitch - pitchDelta, -89f, 89f);
            cameraRoot.localEulerAngles = new Vector3(_pitch, 0f, 0f);
        }
    }
}
