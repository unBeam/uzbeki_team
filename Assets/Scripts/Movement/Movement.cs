using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";

    [SerializeField] private float _speed;
    [SerializeField] private AudioSource _source;

    private CharacterController _characterController;

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
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);



        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;

        _characterController.Move(moveDirection * _speed * Time.deltaTime);
    }
}
