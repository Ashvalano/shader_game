using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractableFatty : MonoBehaviour 
{
    public static Action OnClickFatty;

    public Vector3 InteractPosition()
    {
        return transform.position + transform.forward; 
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
        OnClickFatty.Invoke();
    }

    // public void OnClickAction()
    // {
    //     OnClickFatty.Invoke();
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
