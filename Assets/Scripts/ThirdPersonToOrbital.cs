using UnityEngine;
using Cinemachine;

public class ThirdPersonToOrbital : MonoBehaviour {
    [SerializeField] private CinemachineVirtualCamera[] cameras;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse1))
            cameras[0].enabled = false;
        else if (Input.GetKeyUp(KeyCode.Mouse1))
            cameras[0].enabled = true;
    }
}