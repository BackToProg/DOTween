using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    private MeshRenderer _renderer;
    
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        int duration = 10;
        
        _renderer.material.DOColor(Color.yellow, duration).SetLoops(-1, LoopType.Yoyo);
    }

}
