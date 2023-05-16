using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractableRaccoon : MonoBehaviour , IInteractable
{
    public static Action OnClickRaccoon;

    public void OnClickAction()
    {
        OnClickRaccoon.Invoke();
    }

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
