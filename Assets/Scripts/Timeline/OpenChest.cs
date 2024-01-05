using UnityEngine;
using UnityEngine.Playables;

public class OpenChest : MonoBehaviour {

    [SerializeField] private PlayableDirector timeline;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
            timeline.Play();
    }
}
