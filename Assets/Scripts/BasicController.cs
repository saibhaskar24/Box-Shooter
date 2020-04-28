using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float gravity = 9.81f;

    public CharacterController myController;

    void Start()
    {
        myController = gameObject.GetComponent<CharacterController>();

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
        Vector3 movementX = Input.GetAxis("Horizontal" ) * Vector3.right * moveSpeed * Time.deltaTime;

        Vector3 movement = transform.TransformDirection(movementX + movementZ);

        movement.y -= gravity * Time.deltaTime;

        Debug.Log("Movement "+ movement + "movement Z" + movementZ);

        myController.Move(movement);

    }
}
