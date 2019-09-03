using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class WatchRectTransform : MonoBehaviour
{
    public RectTransform ownRectTransform;
    public RectTransform watched;
    public Rect offset = new Rect(0,0,0,0);
    public bool watching = false;

    private void Update()
    {
        if (watching)
        {
            ownRectTransform.localPosition = watched.localPosition;
            ownRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, watched.rect.width + offset.width);
            ownRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, watched.rect.height + offset.height);
        }
    }
}
