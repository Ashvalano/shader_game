using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractableApple : MonoBehaviour
{
    float distancePosition = 1f;

    public static Action OnClickApple;

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
        OnClickApple.Invoke();
 
    }

    void Start()
    {
        InteractablesManager.AddToInteractablesEvent(transform);
    }

    void OnDisable()
    {
        InteractablesManager.RemoveFromInteractablesEvent(transform);
    }
}

