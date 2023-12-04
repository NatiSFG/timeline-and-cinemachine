using UnityEngine;
using Cinemachine;

public class VirtualCameraSetUp : MonoBehaviour {
    [SerializeField] private Transform cylinder;
    
    private CinemachineVirtualCamera cam;

    void Start() {
        cam = GetComponent<CinemachineVirtualCamera>();
        cam.m_Lens.FieldOfView = 20;
        cam.m_LookAt = cylinder;
    }
}
