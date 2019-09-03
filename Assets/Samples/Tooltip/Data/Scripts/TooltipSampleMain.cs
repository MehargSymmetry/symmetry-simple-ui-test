using Symmetry.UI;
using UnityEngine;

public class TooltipSampleMain : MonoBehaviour
{
    public GameObject tooltipPrefab;
    public Sprite alertSprite;

    private void Start()
    {
        GameObject tooltipInfoGameObject = Instantiate(tooltipPrefab);
        GameObject tooltipAlertGameObject = Instantiate(tooltipPrefab);
        var tooltipInfo = tooltipInfoGameObject.GetComponent<Tooltip>();
        var tooltipAlert = tooltipAlertGameObject.GetComponent<Tooltip>();
        tooltipAlert.Setup("YOU MUST CONSTRUCT ADDITIONAL PYLONS", alertSprite);
        tooltipInfo.Setup("PLEASE JUST DO IT");
        
    }
}
