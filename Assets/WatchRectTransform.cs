using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class WatchRectTransform : MonoBehaviour
{
    public RectTransform watched;
    public Rect offset = new Rect(0,0,0,0);
    public bool watching = false;
    private RectTransform myRectTransform;

    private void Update()
    {
        if (watching)
        {
            myRectTransform.localPosition = watched.localPosition;
            myRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, watched.rect.width + offset.width);
            myRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, watched.rect.height + offset.height);
        }
    }
}
