using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Interactive : MonoBehaviour
{
    [SerializeField]
    private Transform newSelectionTransform;

    public Vector3 InteractPosition()
    {
        return transform.position + transform.forward;
    }

    public void Interact(PlayerScript player)
    {

        if (newSelectionTransform != null)
        {
            IInteractable interactable =
            newSelectionTransform.gameObject.GetComponent<IInteractable>();
            if (interactable != null) { interactable.OnClickAction();}
            newSelectionTransform = null;
        }

        StartCoroutine(WaitforPlayerArriving(player));
    }

    IEnumerator WaitforPlayerArriving(PlayerScript player)
    {
        while(!player.CheckIfArrived())
        {
            yield return null;
        }
        Debug.Log("Player arrived");

        player.SetDirection(transform.position);   
    }

}

