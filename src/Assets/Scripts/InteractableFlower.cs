using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractableFlower : MonoBehaviour 
{
    [SerializeField] float distancePosition = 1f;

    public static Action OnClickFlower;

    public Vector3 InteractPosition()
    {
        return transform.position + transform.forward * distancePosition; 
    }

    public void Interact(PlayerScript player)
    {

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
        OnClickFlower.Invoke();
    }

    // public void OnClickAction()
    // {
    //     OnClickFlower.Invoke();
    // }

    void Start()
    {
        InteractablesManager.AddToInteractablesEvent.Invoke(transform);
    }

    void OnDisable()
    {
        InteractablesManager.RemoveFromInteractablesEvent.Invoke(transform);
    }
}
