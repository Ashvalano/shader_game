using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fatty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InteractableFatty.OnClickFatty 
            += FattyCube;
    }
 
    private void FattyCube()
    {
       transform.DOLocalRotate(new Vector3(360, 0, 0), 1, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative(true).SetEase(Ease.Linear); 
    }
}
