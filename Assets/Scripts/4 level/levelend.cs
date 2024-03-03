using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelend : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;

    private bool _isTrigger;

    private void Update()
    {
        if(_isTrigger == true)
        {
            _nextLevel.ChangeLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isTrigger = true;
    }
}

