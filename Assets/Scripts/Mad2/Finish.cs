using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;
    [SerializeField] private KeyChecker _keyChecker;
    [SerializeField] private Canvas _ECanvas;
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
        _ECanvas.gameObject.SetActive(true);
        _isOpened = _keyChecker.IsOpening();
        _hasPlayer = true;
    }
}
