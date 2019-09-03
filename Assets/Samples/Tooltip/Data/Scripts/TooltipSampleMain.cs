using Symmetry.UI;
using UnityEngine;

public class TooltipSampleMain : MonoBehaviour
{
    public GameObject tooltipPrefab;
    public Sprite alertSprite;

    private void Start()
    {
        GameObject tooltipAlertGameObject = Instantiate(tooltipPrefab);
        var tooltipAlert = tooltipAlertGameObject.GetComponent<Tooltip>();
        tooltipAlert.Setup("YOU MUST CONSTRUCT ADDITIONAL PYLONS\nAnother line\nYet ANOTHER line");
        
    }
}
