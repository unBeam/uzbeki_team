using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PickUp : MonoBehaviour
{
    [SerializeField] private float _checkDistance;
    [SerializeField] private Transform _raycastPoint;
    [SerializeField] private Transform _positionItems;
    [SerializeField] private float _throwForce;
    [SerializeField] private Transform _camera;
    private Rigidbody _rigidBody;
    private bool _onHand;

    public bool OnHand()
    {
        return _onHand;
    }

    void Start()
    {
        //_rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.DrawRay(_camera.position, _camera.forward * _checkDistance, Color.yellow);
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickUpItem();
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            DropItem();
        }
    }

    private void PickUpItem()
    {
        Debug.Log("НАЧАЛО");
        RaycastHit hit;
        if (Physics.Raycast(_camera.position,_camera.forward, out hit, _checkDistance))
        {
            Debug.Log("попали");
            PickUpItems item = hit.collider.GetComponent<PickUpItems>();
            if (item != null)
            {
                Debug.Log("взяли");
                _rigidBody = item.GetComponent<Rigidbody>();
                item.transform.parent = _positionItems.transform;
                item.transform.localPosition = Vector3.zero;
                item.transform.localEulerAngles = Vector3.zero;

                _rigidBody.isKinematic = true;
                _onHand = true;
            }
        }
    }

    private void DropItem()
    {
        if(_onHand == true)
        {
            transform.parent = null;
            _onHand = false;

            _rigidBody.useGravity = true;
            _rigidBody.isKinematic = false;
            _rigidBody.AddForce(_positionItems.forward * _throwForce);
        }
    }
}
