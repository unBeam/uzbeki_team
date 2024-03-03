using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;
    private bool _tigger;

    private void Update()
    {
        if (_tigger == true && Input.GetKeyDown("e")) 
        { 
            _nextLevel.ChangeLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _tigger = true;
    }


}
