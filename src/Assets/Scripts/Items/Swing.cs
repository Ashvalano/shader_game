using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Swing : MonoBehaviour
{
    // [SerializeField]
    // private Transform SwingChair;

    void Start()
    {
        InteractableSwing.OnClickSwing
            += SwingSwing;
    }

    private void SwingSwing()
    {
            transform.DOLocalRotate(new Vector3(0, 0, 50), 0.7f).OnComplete(() => {
                transform.DOLocalRotate(new Vector3(0, 0, -30), 0.7f).OnComplete(() => {
                     transform.DOLocalRotate(new Vector3(0, 0, 20), 0.7f).OnComplete(() =>{
                         transform.DOLocalRotate(new Vector3(0, 0, -5), 1);
                //     });
                     });
            });
        });
    }
}