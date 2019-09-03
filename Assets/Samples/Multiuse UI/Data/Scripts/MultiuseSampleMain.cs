using Symmetry.UI;
using UnityEngine;

public class MultiuseSampleMain : MonoBehaviour
{
    public GameObject dialogPrefab;

    private void Start()
    {
        GameObject dialogGameObject = Instantiate(dialogPrefab);
        var dialogScript = dialogGameObject.GetComponent<UserDialog>();
        dialogScript.SetTitle("Business opportunity");
        dialogScript.SetMessage("Order more pizza next week?");
        dialogScript.SetAcceptButtonLabel("Yes!");
        dialogScript.SetCancelButtonLabel("No");
        dialogScript.SetAcceptButtonOnClick(() => { Debug.Log("Yatta!"); });
        dialogScript.SetCancelButtonOnClick(() => { Debug.Log("Sha-ba-ba...:("); });
    }
}
