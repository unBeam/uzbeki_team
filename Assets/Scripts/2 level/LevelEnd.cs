using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;
    [SerializeField] private AudioSource _audioSource;

    private bool _hasPlayer;
    

    private void Update()
    {
        if (_hasPlayer == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(Soundplay());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _hasPlayer = true;
    }

    IEnumerator Soundplay()
    {
        _audioSource.Play();
        yield return new WaitForSeconds(2);
        _nextLevel.ChangeLevel();
    }
}
