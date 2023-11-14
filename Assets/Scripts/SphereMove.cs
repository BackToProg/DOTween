using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereMove : MonoBehaviour
{
    private void Start()
    {
        Vector3 moveVector = new Vector3(0, 5, 0);
        int duration = 3;
        transform.DOMove(moveVector, duration).SetLoops(-1,LoopType.Yoyo);
    }
}
