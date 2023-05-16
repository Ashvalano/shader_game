using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractablesManager : MonoBehaviour
{
    [SerializeField]
    private List<Transform> interactables;

    public List<Transform> Interactables
    {
        get => interactables;
    }

    private Camera mainCamera;


    public Transform target;

    public static Action<Transform> AddToInteractablesEvent;
    public static Action<Transform> RemoveFromInteractablesEvent;

    public Vector3 screenPosition;
    public Vector3 worldPosition;


    private void Awake()
    {
        AddToInteractablesEvent += AddToListofInteractables;
        RemoveFromInteractablesEvent += RemoveFromListofInteractables;
    }

    private void AddToListofInteractables(Transform transformToAddToList)
    {
        interactables.Add(transformToAddToList);   
    }

    private void RemoveFromListofInteractables(Transform transformToRemoveFromList)
    {
        interactables.Remove(transformToRemoveFromList);
    }

    void Start()
    {
        mainCamera = GetComponent<Camera>();

        AllChildrenWorldToScreenPoint();
    }   

    private void AllChildrenWorldToScreenPoint()
    {
        //screenPosition = Input.mousePosition;

        UnityEngine.Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            if (hit.collider != null)
            {   
                mainCamera.ScreenPointToRay(transform.GetChild(i).position);
                transform.GetChild(i).localScale = Vector3.one * 100;
            }
            // transform.GetChild(i).position =
            //     mainCamera.ScreenPointToRay(transform.GetChild(i).position);

            // transform.GetChild(i).localScale = Vector3.one * 100;
        }
        }
    }

 }
