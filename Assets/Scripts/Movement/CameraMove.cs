using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private readonly string MouseX = "Mouse X";
    private readonly string MouseY = "Mouse Y";

    [SerializeField] private float _speed;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _body;
    [SerializeField] private float _maxYAngle = 60f;

    private float _rotationX = 0.0f;

    private void Update()
    {
        //_camera.Rotate(Mathf.Clamp(_speed * -Input.GetAxis(MouseY),-_maxYAngle,_maxYAngle) * Time.deltaTime * Vector3.right);

        _rotationX -= Input.GetAxis(MouseY) * _speed * Time.deltaTime;
        _rotationX = Mathf.Clamp(_rotationX, -_maxYAngle, _maxYAngle);
        _camera.localRotation = Quaternion.Euler(_rotationX, 0.0f, 0.0f);

        _body.Rotate(_speed * Input.GetAxis(MouseX) * Time.deltaTime * Vector3.up);
    }
}
