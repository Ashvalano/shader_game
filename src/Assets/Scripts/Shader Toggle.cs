using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShaderToggle : MonoBehaviour
{
    [SerializeField]
    private InputAction Shader;
    
    private void OnEnable() {
        gameObject.layer = 0;
    }

}
