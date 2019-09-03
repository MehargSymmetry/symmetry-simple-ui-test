using UnityEngine;
using UnityEngine.UI;

namespace Symmetry.UI
{
    public class SpeechBubble : MonoBehaviour
    {
        [SerializeField]
        private Text bodyTextField;
        [SerializeField]
        private Image background;

        public void SetText(string text)
        {
            bodyTextField.text = text;
        }

        public void SetPanelColor(Color color)
        {
            background.color = color;
        }
    }
}