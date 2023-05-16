using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShaderTest : MonoBehaviour
{
    [SerializeField]
    private InputAction Toggle;

    private bool Layer = true;

    void Start()
    {
        gameObject.layer = 8;
        Toggle.Enable();
    }


    void OnEnable()
    {
        Toggle.performed += ctx => ShaderLayer();
    }

    private void ShaderLayer(){
        if (Layer) {
            foreach (Transform child in gameObject.GetComponentsInChildren<Transform>(true))  
      {
                child.gameObject.layer = LayerMask.NameToLayer ("Default");  // add any layer you want. 
      }
          
            framerate.target = 60;
        }
        else {
            foreach (Transform child in gameObject.GetComponentsInChildren<Transform>(true))  
      {
                child.gameObject.layer = LayerMask.NameToLayer ("pixel");  // add any layer you want. 
      }
            framerate.target = 12;
        }
        Layer = !Layer;
    }
}


