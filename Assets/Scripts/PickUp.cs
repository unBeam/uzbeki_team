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

    private Rigidbody _rigidBody;
    private bool _onHand;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
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
        //RaycastHit hit;
        //Debug.Log(2);
        //if (Physics.Raycast(_raycastPoint.position, _raycastPoint.forward, out hit, _checkDistance))
        //{
        //    Debug.Log(3);
        //    GameObject _item = hit.collider.GetComponent<GameObject>();

        //    if (_item != null && _onHand == false)
        //    {
        //        _item.transform.parent = _positionItems.transform;
        //        _item.transform.localPosition = Vector3.zero;
        //        _item.transform.localEulerAngles = Vector3.zero;
        //        _onHand = true;
        //    }
        //}
        Ray ray = Camera.main.ScreenPointToRay(_raycastPoint.forward);

        if (Physics.Raycast(ray, _checkDistance))
        {
            transform.parent = _positionItems.transform;
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
            _rigidBody.isKinematic = true;
            _onHand = true;
        }
    }

    private void DropItem()
    {
        if(_onHand == true)
        {
            _onHand = false;
            _rigidBody.useGravity = true;
            _rigidBody.isKinematic = false;
            _rigidBody.AddForce(_positionItems.forward * _throwForce);
        }
    }
}
