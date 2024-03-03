using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;
    [SerializeField] private KeyChecker _keyChecker;

    private bool _hasPlayer;
    private bool _isOpened;


    private void Update()
    {
        if (_hasPlayer == true && _isOpened == true && Input.GetKeyDown(KeyCode.E))
        {
            _nextLevel.ChangeLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isOpened = _keyChecker.IsOpening();
        _hasPlayer = true;
    }
}
