using UnityEngine;
using UnityEngine.Events;

namespace ThirdPartyTest.Main
{
    public class StatusPrompt : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent<string> _promptTextEvent;

        private void Update()
        {
            _promptTextEvent.Invoke(
                "Status\n" +
                "Something\n" +
                // ReSharper disable once StringLiteralTypo
                "Long\n" +
                "Text");
        }
    }
}