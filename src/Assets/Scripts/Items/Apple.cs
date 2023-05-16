using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Apple : MonoBehaviour
{
    void Start()
    {
        InteractableApple.OnClickApple
            += AppleFall;
    }

    private void AppleFall()
    {
        transform.DOMoveY(2.547f,0.5f).OnComplete(() => {
            transform.DORotate(new Vector3(70, 0, 0), 3).SetEase(Ease.Linear);
                transform.DOMoveX(-0.5f, 3);
        });
    }
}

