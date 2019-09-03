using System;
using UnityEngine;
using UnityEngine.UI;

namespace Symmetry.UI
{
    public class Tooltip : MonoBehaviour
    {
        [SerializeField]
        private Image alertIcon;
        [SerializeField]
        private Text tipTextFieldInfo;
        [SerializeField]
        private Text tipTextFieldAlert;
        private GameObject layoutInfo; //Has text only
        private GameObject layoutAlert; //Has icon
        

        //PUBLIC METHODS
        public void Setup(string tooltipText, Sprite alertSprite = null)
        {
            SetText(tooltipText);
            SetIconSprite(alertSprite);
        }

        public void SetText(string tooltipText)
        {
            tipTextFieldInfo.text = tooltipText;
            tipTextFieldAlert.text = tooltipText;
        }

        public void SetIconSprite(Sprite sprite)
        {
            this.alertIcon.sprite = sprite;
            UpdateLayout();
        }

        //PRIVATE METHODS
        /// <summary>
        /// Updates which version of the tool tip to view:
        /// The "alert" one which comes with an icon,
        /// or the "info" one which comes with only text.
        /// </summary>
        private void UpdateLayout()
        {
            layoutInfo = tipTextFieldInfo.transform.parent.gameObject;
            layoutAlert = tipTextFieldAlert.transform.parent.gameObject;
            layoutInfo.SetActive(alertIcon.sprite == null);
            layoutAlert.SetActive(alertIcon.sprite != null);
        }
    }
}
