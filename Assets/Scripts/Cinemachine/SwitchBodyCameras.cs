using UnityEngine;
using Cinemachine;

public class SwitchBodyCameras : MonoBehaviour {
    [SerializeField] private CinemachineVirtualCamera[] cameras;

    private int index;

    private void Start() {
        for (int i = 1; i < cameras.Length; i++)
            cameras[i].enabled = false;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            cameras[index].enabled = false;
            index++;

            if (index >= cameras.Length)
                index = 0;
            cameras[index].enabled = true;
        }
    }
}