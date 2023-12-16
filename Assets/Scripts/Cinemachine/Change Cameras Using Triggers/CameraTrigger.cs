using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CameraTrigger : MonoBehaviour {
    [SerializeField] private CameraManager manager;
    private bool steppedInTrigger;
    public bool SteppedInTrigger => steppedInTrigger;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            steppedInTrigger = true;
            manager.DeactivateCameras();
            manager.currentCamIndex = 1;
            manager.SetActiveCamera(manager.currentCamIndex);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            steppedInTrigger = false;
            manager.currentCamIndex = 0;
            manager.SetActiveCamera(manager.currentCamIndex);
        }
    }
}
