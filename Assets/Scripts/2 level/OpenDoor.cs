using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private AnimDoor _anim;
    [SerializeField] private PickUp _pickUp;
    [SerializeField] private Image _image;

    private bool _keyOnHand;

    private void OnTriggerEnter(Collider other)
    {
        _keyOnHand = _pickUp.OnHand();

        if(other.gameObject.tag == "Player" && _keyOnHand == true)
        {
            _anim.OpeningDoor();
        }
        else
        {
            _image.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _image.gameObject.SetActive(false);
    }
}
