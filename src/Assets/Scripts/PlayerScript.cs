using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
 
public class PlayerScript : MonoBehaviour {
 
    private NavMeshAgent agent;
    private Camera mainCamera;

    private bool turning;
    private Quaternion targetRot;
 
	// Use this for initialization
	void Start ()
    {
        mainCamera = Camera.main;
        
 
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
 
    {
        if (Input.GetMouseButtonDown(0))
            OnClick();

        if (turning && transform.rotation != targetRot)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, 5f * Time.deltaTime);
        }
	}
 
 
    void OnClick()
    {
        Debug.Log("Left Clicked!");
 
        RaycastHit hit;
        Ray camToScreen = mainCamera.ScreenPointToRay(Input.mousePosition);
 
        if (Physics.Raycast(camToScreen, out hit,Mathf.Infinity))
        {
            if (hit.collider != null)
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                InteractableFatty interactable2 = hit.collider.GetComponent<InteractableFatty>();
                InteractableFlower interactable3 = hit.collider.GetComponent<InteractableFlower>();
                InteractableCar interactable4 = hit.collider.GetComponent<InteractableCar>();
                InteractableApple interactable5 = hit.collider.GetComponent<InteractableApple>();
                InteractableSwing interactable6 = hit.collider.GetComponent<InteractableSwing>();
                InteractableSkeleton interactable7 = hit.collider.GetComponent<InteractableSkeleton>();
                InteractableCan interactable8 = hit.collider.GetComponent<InteractableCan>();
                InteractableFrog interactable9 = hit.collider.GetComponent<InteractableFrog>();
                InteractableCoin interactable10 = hit.collider.GetComponent<InteractableCoin>();
                
                if (interactable != null)
                {
                    MovePlayer(interactable.InteractPosition());
                    interactable.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable2 != null)
                {
                    MovePlayer(interactable2.InteractPosition());
                    interactable2.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable3 != null)
                {
                    MovePlayer(interactable3.InteractPosition());
                    interactable3.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable4 != null)
                {
                    MovePlayer(interactable4.InteractPosition());
                    interactable4.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable5 != null)
                {
                    MovePlayer(interactable5.InteractPosition());
                    interactable5.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable6 != null)
                {
                    MovePlayer(interactable6.InteractPosition());
                    interactable6.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable7 != null)
                {
                    MovePlayer(interactable7.InteractPosition());
                    interactable7.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable8 != null)
                {
                    MovePlayer(interactable8.InteractPosition());
                    interactable8.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable9 != null)
                {
                    MovePlayer(interactable9.InteractPosition());
                    interactable9.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
                if (interactable10 != null)
                {
                    MovePlayer(interactable10.InteractPosition());
                    interactable10.Interact(this);
                }
                else
                {
                    MovePlayer(hit.point);
                }
            }
        }
    }

    public bool  CheckIfArrived()
    {
        return (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance);
    }
 
    void MovePlayer(Vector3 targetPosition)
    {
        turning = false;

        agent.SetDestination(targetPosition);
    }

    public void SetDirection(Vector3 targetDirection)
    {
        turning = true;
        targetRot = Quaternion.LookRotation(targetDirection - transform.position);
    }
}