using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();

        InteractableCar.OnClickCar
            += CarLight;
    }

    private void CarLight()
    {
        
        {
        myLight.enabled = !myLight.enabled; 
        }
    }
}
