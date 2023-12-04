using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour {
    private CinemachineImpulseSource source;

    private void Start() {
        source = GetComponent<CinemachineImpulseSource>();
    }

    private void Update() {
        if (Input.GetKey(KeyCode.Space))
            Shake();
    }

    public void Shake() {
        source.GenerateImpulse();
    }
}