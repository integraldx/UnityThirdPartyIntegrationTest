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
            var unityServicesState = Unity.Services.Core.UnityServices.State;
            
            _promptTextEvent.Invoke(
                "Status\n" +
                $"Unity Services: {unityServicesState}");
        }
    }
}