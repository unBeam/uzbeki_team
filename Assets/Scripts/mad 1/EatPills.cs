using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EatPills : MonoBehaviour
{
    [SerializeField] NextLevel _nextLevel;
    [SerializeField] AnimDoor _anim;

    private bool _zonePills;
    private void Update()
    {
        if(_zonePills == true && Input.GetKey(KeyCode.E))
        {
            _anim.OpeningDoor();
            StartCoroutine(NextLevel());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _zonePills = true;
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(8);
        _nextLevel.ChangeLevel();
    }
}
