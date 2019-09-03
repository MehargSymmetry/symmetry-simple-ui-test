using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAndRotateSampleMain : MonoBehaviour
{
    [SerializeField]
    private GameObject rotateButtonPrefab;

    public Transform buttonParent;
    public GameObject[] rotateable;

    private void Start()
    {
        foreach (var target in rotateable)
        {
            var newButtonObj = GameObject.Instantiate(rotateButtonPrefab);
            newButtonObj.transform.parent = buttonParent;
            var newButton = newButtonObj.GetComponent<PickUpAndRotateButton>();
            newButton.transform.localPosition = target.transform.localPosition;
            newButton.transform.Translate(new Vector3(0, 3));
            newButton.target = target.transform;
        }
    }

}
