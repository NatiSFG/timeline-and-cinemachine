using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour {
    [SerializeField] private GameObject[] cams;
    [SerializeField] private CameraTrigger trigger;
    
    public int currentCamIndex;

    private void Update() {
        if (trigger.SteppedInTrigger) {
            if (Input.GetKeyDown(KeyCode.C) && currentCamIndex < cams.Length - 1) {
                currentCamIndex++;
                SetActiveCamera(currentCamIndex);
            } else if (Input.GetKeyDown(KeyCode.C) && currentCamIndex >= cams.Length - 1) {
                currentCamIndex = 1;
                SetActiveCamera(currentCamIndex);
            }
        }
    }

    public void DeactivateCameras() {
        foreach (var c in cams)
            c.SetActive(false);
    }

    public void SetActiveCamera(int activeCamera) {
        DeactivateCameras();
        cams[activeCamera].SetActive(true);
    }
}