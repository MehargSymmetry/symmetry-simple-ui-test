using Symmetry.UI;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpaceSampleMain : MonoBehaviour
{
    private List<SpeechBubble> bubbleList = new List<SpeechBubble>();
    [SerializeField]
    private GameObject bubblePrefab;

    public GameObject[] speakers;
    public string[] quotes;


	void Start ()
    {
        AddBubblesToSpeakers();
        UpdateSpeakerBubbles();
	}

    void Update ()
    {
        if (UnityEngine.Random.Range(0f, 1f) < .989f)
            return;

        UpdateSpeakerBubbles();
    }

    #region PRIVATE METHODS

    private void AddBubblesToSpeakers()
    {
        foreach (var speaker in speakers)
        {
            var bubble = Instantiate<GameObject>(bubblePrefab);
            bubble.transform.SetParent(speaker.transform, false);
            bubbleList.Add(bubble.GetComponent<SpeechBubble>());
        }
    }

    private void UpdateSpeakerBubbles()
    {
        foreach (var item in bubbleList)
        {
            var randomIndex = UnityEngine.Random.Range(0, quotes.Length);
            item.SetText(quotes[randomIndex]);
        }
    }

    #endregion
}
