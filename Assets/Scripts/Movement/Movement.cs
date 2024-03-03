using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";

    [SerializeField] private float _speed;

    private CharacterController _characterController;
    //private float _fallSpeed = 9.8f;
    private float _time;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();

    }

    private void Update()
    {
        _characterController.SimpleMove(Vector3 .forward * 0);
        Move();
    }

    private void Move()
    {
        //Vector3 direction = new Vector3(Input.GetAxis(Horizontal), 0f, Input.GetAxis(Vertical));

        //_rigidBody.MovePosition(direction * _speed * Time.fixedDeltaTime);

        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);

        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;

        //moveDirection.y -= 9.8f * Time.deltaTime;
        

        _characterController.Move(moveDirection * _speed * Time.deltaTime);
    }
}
