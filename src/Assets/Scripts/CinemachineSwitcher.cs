using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField]
    private InputAction action1;

    private Animator animator;
    private bool camera1 = true;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void OnEnable() {
        action1.Enable();
    }

    private void OnDisable() {
        action1.Disable();
    }

    void Start()
    {
        action1.performed += _ => SwitchState();
    }

    private void SwitchState() {
        if (camera1) {
            animator.Play("Camera 2");
        }
        else {
            animator.Play("Camera 1");
        }
        camera1 = !camera1;
    }

}
