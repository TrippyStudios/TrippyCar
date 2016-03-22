using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 15;
    private Vector3 moveDir;

	void Update () {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Jump"), 1).normalized;
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
    }
}
