using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    private const string EnterText = " Дополняем текст";
    private const string ChangeText = "Новый текст";
    private const string HackText = "Сломали текст";

    [SerializeField] private Text _text;
    
    private void Start()
    {
        const float Duration = 3;
        const float DelayToChangeText = 5;
        const float DelayToHackText = 10;
        
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(EnterText, Duration).SetRelative());
        sequence.Insert(DelayToChangeText, _text.DOText(ChangeText, Duration));
        sequence.Insert(DelayToHackText, _text.DOText(HackText, Duration, true, ScrambleMode.All));
    }
}
