using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;

    private bool _hasPlayer;

    private void Update()
    {
        if (_hasPlayer == true && Input.GetKeyDown(KeyCode.E))
        {
            _nextLevel.ChangeLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _hasPlayer = true;
    }
}
