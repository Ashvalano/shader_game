using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Can : MonoBehaviour
{
    [SerializeField]
    private Transform Can1;
    [SerializeField]
    private Transform Can2;
    [SerializeField]
    private Transform Can3;
    [SerializeField]
    private Transform Can4;
    void Start()
    {
        InteractableCan.OnClickCan
            += CanShoot;
    }

    private void CanShoot()
    {
        Can1.DOLocalMove(new Vector3(-3.766f, 0f, 20.83f), 1);
        Can1.DOLocalRotate(new Vector3(-90f, 0f, -222.364f), 1).OnComplete(()=> {
            Can2.DOLocalMove(new Vector3(-3.766f, 0f, 19.102f), 1);
            Can2.DOLocalRotate(new Vector3(-90f, 0f, -222.364f), 1).OnComplete(() => {
                Can3.DOLocalMove(new Vector3(-3.766f, 0f, 17.557f), 1);
                Can3.DOLocalRotate(new Vector3(-90f, 0f, -222.364f), 1).OnComplete(() => {
                    Can4.DOLocalMove(new Vector3(-3.766f, 0f, 16.207f), 1);
                    Can4.DOLocalRotate(new Vector3(-90f, 0f, -222.364f), 1);
                });
            });
        });
    }
}
