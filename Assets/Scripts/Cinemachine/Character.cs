using UnityEngine;

public class Character : MonoBehaviour {
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    
    private CharacterController controller;
    private Vector3 dir;

    private void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        dir = new Vector3(horizontal, 0, vertical);
        dir *= moveSpeed * Time.deltaTime;
        controller.Move(dir);

        //Vector3 rotation = new Vector3(0, horizontal * rotateSpeed * Time.deltaTime, 0);
        //this.transform.Rotate(rotation);
    }
}