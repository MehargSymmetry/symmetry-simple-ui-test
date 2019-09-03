using System;
using UnityEngine;
using UnityEngine.UI;

namespace Symmetry.UI
{
    public class UserDialog : MonoBehaviour
    {
        [SerializeField]
        private Text titleText;
        [SerializeField]
        private Text messageText;
        [SerializeField]
        private Button cancelButton;
        [SerializeField]
        private Button acceptButton;

        public Action OnAcceptButtonClickAction { get; private set; }
        public Action OnCancelButtonClickAction { get; private set; }

        public void SetTitle(string titleText)
        {
            this.titleText.text = titleText;
        }

        public void SetMessage(string messageText)
        {
            this.messageText.text = messageText;
        }

        public void SetCancelButtonLabel(string value)
        {
            cancelButton.GetComponentInChildren<Text>().text = value;
        }

        public void SetAcceptButtonLabel(string value)
        {
            acceptButton.GetComponentInChildren<Text>().text = value;
        }

        public void SetAcceptButtonOnClick(Action onAccept)
        {
            OnAcceptButtonClickAction = onAccept;
        }

        public void SetCancelButtonOnClick(Action onCancel)
        {
            OnCancelButtonClickAction = onCancel;
        }

        #region PRIVATE METHODS

        private void Awake()
        {
            OnAcceptButtonClickAction = () => { };
            OnCancelButtonClickAction = () => { };
            
        }

        private void Start()
        {

            cancelButton.onClick.AddListener(OnCancelClick);
            acceptButton.onClick.AddListener(OnAcceptClick);
        }

        private void OnCancelClick()
        {
            OnCancelButtonClickAction();
        }

        private void OnAcceptClick()
        {
            OnAcceptButtonClickAction();
        }

        #endregion

    }
}