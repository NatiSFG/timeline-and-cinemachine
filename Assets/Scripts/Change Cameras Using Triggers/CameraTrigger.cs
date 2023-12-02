using UnityEngine;

public class CameraTrigger : MonoBehaviour {
    [SerializeField] private CameraManager camManager;
    [SerializeField] private int currentCam;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            camManager.ResetAllCams();
            camManager.SetActiveCam(currentCam);
        }
    }
}