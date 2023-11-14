using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using DG.Tweening;

public class CubeRotation : MonoBehaviour
{
    private void Start()
    {
        Vector3 rotateVector = new Vector3(180, 0, 0);
        int duration = 3;
        
        transform.DORotate(rotateVector, duration).SetLoops(-1, LoopType.Yoyo);
    }
}
