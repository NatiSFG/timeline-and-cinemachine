using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    private PlayableDirector timeline;

    private void Start() {
        timeline = GetComponent<PlayableDirector>();
    }

    public void LoadAScene() {
        SceneManager.LoadScene("Scene 2");
    }
}
