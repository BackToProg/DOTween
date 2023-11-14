using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CapsuleScaleChange : MonoBehaviour
{
    private void Start()
    {
        Vector3 scaleVector = new Vector3(2, 2, 2);
        int duration = 3;
        
        transform.DOScale(scaleVector, duration).SetLoops(-1, LoopType.Yoyo);
    }
}
