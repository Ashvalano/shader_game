using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
public class ClickToMove : MonoBehaviour
{
    [SerializeField]
    private InputAction mouseClickAction;
    [SerializeField]
    private float playerSpeed = 10f;
    [SerializeField]
    private float rotationSpeed = 3f;

    private Camera mainCamera;
    private Coroutine coroutine;
    private Vector3 targetPosition;

    private CharacterController characterController;
    private Rigidbody rb;

    private void Awake() {
        mainCamera = Camera.main;
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable() {
        mouseClickAction.Enable();
        mouseClickAction.performed += Move;
    }

    private void OnDisable() {
        mouseClickAction.performed -= Move;
        mouseClickAction.Disable();
    }

    private void Move(InputAction.CallbackContext context) {
        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray: ray, hitInfo: out RaycastHit hit) && hit.collider) {
            if (coroutine != null) StopCoroutine(coroutine);
            coroutine = StartCoroutine(PlayerMoveTowards(hit.point));
            targetPosition = hit.point;
        }
    }

    private IEnumerator PlayerMoveTowards(Vector3 target) {
        float playerDistanceToFloor = transform.position.y - target.y;
        target.y += playerDistanceToFloor;
        while (Vector3.Distance(transform.position, target) > 1f) {
            // Ignores Collisions
            Vector3 destination = Vector3.MoveTowards(transform.position, target, playerSpeed * Time.deltaTime);
            // transform.position = destination;

            //Character Controller
            Vector3 direction = target - transform.position;
            Vector3 movement = direction.normalized * playerSpeed * Time.deltaTime;
            //characterController.Move(movement);

            //Rigidbody
            rb.velocity = direction.normalized * playerSpeed;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction.normalized), rotationSpeed * Time.deltaTime);

            yield return null;
        }
    }

}