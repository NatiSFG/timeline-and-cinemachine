using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateAnimations : MonoBehaviour {
    private Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
    }

    void Update() {
        if (Keyboard.current.qKey.wasPressedThisFrame) anim.SetTrigger("Death");

        if (Mouse.current.rightButton.isPressed) anim.SetBool("isAiming", true);
        else if (Mouse.current.rightButton.wasReleasedThisFrame) anim.SetBool("isAiming", false);
    }
}
