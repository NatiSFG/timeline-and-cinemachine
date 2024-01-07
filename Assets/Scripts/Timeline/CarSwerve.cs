using UnityEngine;
using UnityEngine.Playables;

public class CarSwerve : MonoBehaviour {

    [SerializeField] private PlayableDirector timeline;

    private void OnTriggerEnter(Collider other) {
        timeline.Play();
    }
}