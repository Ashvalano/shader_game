using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Flower : MonoBehaviour
{
    [SerializeField]
    private Transform FlowerModel;

    private Vector3 _originalScale;
    private Vector3 _scaleTo;
    
    // Start is called before the first frame update
    void Start()
    {
        InteractableFlower.OnClickFlower
            += FlowerGrow;

        _originalScale = transform.localScale;
        _scaleTo = _originalScale *1.5f;

    }

    private void FlowerGrow()
    {   
        
        FlowerModel.DOLocalMoveY(0.103f, 5);
        transform.DOScale(_scaleTo, 2.0f);
    }

}
