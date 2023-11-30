using Cinemachine;
using UnityEngine;


public class SwitchLookAtAndZoom : MonoBehaviour {
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject cylinder;

    private CinemachineVirtualCamera cam;
    private bool isCubeTarget;

    private void Start() {
        cam = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update() {
        SwitchLookAtObject();
        FieldOfViewCycling();
    }

    private void SwitchLookAtObject() {
        if (Input.GetKeyDown(KeyCode.R) && isCubeTarget) {
            cam.m_LookAt = cylinder.transform;
            isCubeTarget = false;
        }
        else if (Input.GetKeyDown(KeyCode.R) && !isCubeTarget) {
            cam.m_LookAt = cube.transform;
            isCubeTarget = true;
        }
    }

    private void FieldOfViewCycling() {
        if (Input.GetKeyDown(KeyCode.Space) && cam.m_Lens.FieldOfView >= 40)
            cam.m_Lens.FieldOfView -= 20;
        else if (Input.GetKeyDown(KeyCode.Space) && cam.m_Lens.FieldOfView <= 20)
            cam.m_Lens.FieldOfView = 60;
    }
}
