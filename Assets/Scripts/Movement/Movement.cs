using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    private readonly string Horizontal = "Horizontal";
    private readonly string Vertical = "Vertical";

    [SerializeField] private float _speed;
    [SerializeField] private AudioSource _steps;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            if (_steps.isPlaying == false)
            {
                _steps.Play();
            }
        }
        else
        {
            _steps.Stop();
        }
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
