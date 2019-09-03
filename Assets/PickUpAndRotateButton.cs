using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using System;

public class PickUpAndRotateButton : MonoBehaviour
{
    public Transform target;

    private bool animating = false;

    void Awake()
    {
        GetComponent<Canvas>().worldCamera = Camera.main;
        transform.DOLocalRotate(new Vector3(0f,0f,360f), 2f, RotateMode.LocalAxisAdd).SetLoops(-1);
    }

    void AnimatingFinished()
    {
        animating = false;
    }

    public void AnimateParent()
    {
        if (!animating)
        {
            animating = true;
            var animationSequence = DOTween.Sequence();
            animationSequence.Append(target.DOLocalMoveY(4f, 5f));
            animationSequence.Insert(1f, target.DOLocalRotate(new Vector3(0, 0, 90), 2f, RotateMode.LocalAxisAdd));
            animationSequence.OnComplete(AnimatingFinished);
            animationSequence.Play();
        }
    }
}
