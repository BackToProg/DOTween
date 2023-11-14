using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        int duration = 10;
        
        renderer.material.DOColor(Color.yellow, duration).SetLoops(-1, LoopType.Yoyo);
    }

}
