using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemActivation : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        InteractablesManager.AddToInteractablesEvent(transform);
    }

    // Update is called once per frame
    void OnDisable()
    {
        InteractablesManager.RemoveFromInteractablesEvent(transform);
    }
}