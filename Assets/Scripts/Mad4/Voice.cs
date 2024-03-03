using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voice : MonoBehaviour
{
    [SerializeField] private Image _image;
    private bool _isTrigger;

    private void Update()
    {
        if(_isTrigger == true)
        {
            StartCoroutine(VoiceStart());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _image.gameObject.SetActive(true);
        _isTrigger = true;
    }

    IEnumerator VoiceStart()
    {
        yield return new WaitForSeconds(6);
       _image.gameObject.SetActive(false);
    }
}
