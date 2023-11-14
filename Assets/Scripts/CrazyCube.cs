using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CrazyCube : MonoBehaviour
{
    private void Start()
    {
        int duration = 1;
        Vector3 scaleVector = new Vector3(2, 2, 2);
        Vector3 moveVector = new Vector3(0, -5, 0);
        Vector3 rotateVector = new Vector3(180, 0, 0);
        
        transform.DOMove(moveVector, duration).SetLoops(-1,LoopType.Yoyo);
        transform.DORotate(rotateVector, duration).SetLoops(-1, LoopType.Yoyo);
        transform.DOScale(scaleVector, duration).SetLoops(-1, LoopType.Yoyo);
    }
}
