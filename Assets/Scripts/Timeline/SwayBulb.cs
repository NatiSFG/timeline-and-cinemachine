using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwayBulb : MonoBehaviour {

    [SerializeField] private GameObject timeline;

    void Update() {
        if (Input.GetKeyDown(KeyCode.K))
            timeline.SetActive(true);
    }
}
