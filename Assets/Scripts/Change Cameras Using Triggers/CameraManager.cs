using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour {
    [SerializeField] private CinemachineVirtualCamera[] cams;

    public void ResetAllCams() {
        foreach (var cam in cams)
            cam.m_Priority = 10;
    }

    public void SetActiveCam(int camera) {
        cams[camera].m_Priority = 15;
    }
}