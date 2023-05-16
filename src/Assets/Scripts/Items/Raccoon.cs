using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Raccoon : MonoBehaviour
{
    
    [SerializeField]
    private Transform _RaccBK;

    // Start is called before the first frame update
    void Start()
    {
        Interactable.OnClickRaccoon2
            += RaccoonSaysHey;
    }

    private void RaccoonSaysHey()
    {
        _RaccBK.DOLocalMove(new Vector3(-17.31f,-23.288f,-13.734f), 5).OnComplete(() => {
        transform.DOMoveY(5,20);
        _RaccBK.DOLocalRotate(new Vector3(0, 360, 0), 1, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative(true).SetEase(Ease.Linear);
        });
    }

}
