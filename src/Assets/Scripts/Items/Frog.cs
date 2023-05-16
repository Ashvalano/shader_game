using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Frog : MonoBehaviour
{
    
    [SerializeField]
    private Transform FrogThing;    
    [SerializeField]
    public Transform Lid;                                                

    // Start is called before the first frame update
    void Start()
    {
        InteractableFrog.OnClickFrog
            += SewerFrog;
    }

    private void SewerFrog()
    {
        Lid.DOLocalMove(new Vector3 (-6.016996f, 0.2217317f, -41.102f), 2);
        FrogThing.DOLocalMove(new Vector3(-5.911345f,-0.027f,-39.09116f), 5);
    }

}