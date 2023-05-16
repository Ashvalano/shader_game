using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private Transform CoinThing;   
       
    void Start()
    {
        InteractableCoin.OnClickCoin
            += CoinFlip;
    }

    private void CoinFlip()
    {
        CoinThing.DOLocalMove(new Vector3(-34.82043f,21.661f,-41.846f), 0.3f).OnComplete(() => {
            CoinThing.DOLocalMove(new Vector3(-34.82043f,20.228f,-41.15f), 0.3f);
        });
    }

}