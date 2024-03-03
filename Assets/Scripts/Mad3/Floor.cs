using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    [SerializeField] private Transform _ceiling;
    [SerializeField] private float _speed;
    [SerializeField] private Image _image;
    private bool ceilingDown = false;
    
    private void Update()
    {
        if(ceilingDown == true)
        {
            float positionY = _ceiling.transform.position.y;
            positionY -= _speed * Time.deltaTime;
            _ceiling.transform.position = new Vector3(0,positionY,0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _image.gameObject.SetActive(true);
        ceilingDown = true;
    }
}
