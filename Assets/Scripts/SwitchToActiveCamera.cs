using System;
using UnityEngine;


public class SwitchToActiveCamera : MonoBehaviour {
    [SerializeField] private GameObject[] cameras;
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
        }
    }
}
