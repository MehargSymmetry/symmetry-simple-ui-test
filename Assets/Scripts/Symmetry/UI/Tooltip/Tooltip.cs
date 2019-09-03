using System;
using UnityEngine;
using UnityEngine.UI;

namespace Symmetry.UI
{
    public class Tooltip : MonoBehaviour
    {
        [SerializeField]
        private Text tipTextField;
        

        //PUBLIC METHODS
        public void Setup(string tooltipText)
        {
            SetText(tooltipText);
        }

        public void SetText(string tooltipText)
        {
            tipTextField.text = tooltipText;
        }
    }
}
