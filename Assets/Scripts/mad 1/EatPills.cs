using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EatPills : MonoBehaviour
{
    [SerializeField] NextLevel _nextLevel;
    [SerializeField] AnimDoor _anim;
    [SerializeField] Canvas _ECanvas;

    private bool _zonePills;
    private void Update()
    {
        if(_zonePills == true && Input.GetKey(KeyCode.E))
        {
            _anim.OpeningDoor();
            StartCoroutine(NextLevel());
            _ECanvas.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _zonePills = true;
        _ECanvas.gameObject.SetActive(true);
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(8);
        _nextLevel.ChangeLevel();
    }
}
