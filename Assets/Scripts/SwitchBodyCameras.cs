using UnityEngine;
using Cinemachine;

public class SwitchBodyCameras : MonoBehaviour {
    [SerializeField] private CinemachineVirtualCamera[] cameras;

    private int index;

    private void Start() {
        //disable all cameras except the first one initially
        for (int i = 1; i < cameras.Length; i++)
            cameras[i].enabled = false;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            //disable the current active camera
            cameras[index].enabled = false;
            index++;

            //if we reached the end of the array, wrap around to the first camera
            if (index >= cameras.Length)
                index = 0;

            //enable the new current camera
            cameras[index].enabled = true;
        }
    }
}