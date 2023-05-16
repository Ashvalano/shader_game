using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Skeleton : MonoBehaviour
{

    [SerializeField]
    private Transform SkeletonArm;
    // Start is called before the first frame update
    void Start()
    {
        InteractableSkeleton.OnClickSkeleton
            += SkeletonWave;
    }

    private void SkeletonWave()
    {
        SkeletonArm.DOLocalMove(new Vector3(-0.1436f, -0.0066f, -0.0034f), 0.5f).SetEase(Ease.Linear);
        SkeletonArm.DOLocalRotate(new Vector3(0.388f, -6.994f, -31.282f), 0.5f).SetEase(Ease.Linear).OnComplete(() => {
            SkeletonArm.DOLocalMove(new Vector3(0f, 0f, 0f), 0.5f).SetEase(Ease.Linear);
            SkeletonArm.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.5f).SetEase(Ease.Linear).OnComplete(() => {
                SkeletonArm.DOLocalMove(new Vector3(0.097f, 0.0615f, -0.0081f), 0.5f).SetEase(Ease.Linear);
                SkeletonArm.DOLocalRotate(new Vector3(-3.527f, 6.021f, 25.331f), 0.5f).SetEase(Ease.Linear).OnComplete(() => {
                    SkeletonArm.DOLocalMove(new Vector3(0f, 0f, 0f), 0.5f).SetEase(Ease.Linear);
                    SkeletonArm.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.5f).SetEase(Ease.Linear);
                });
            });
        });
    }
}
