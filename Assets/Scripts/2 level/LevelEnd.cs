using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private NextLevel _nextLevel;
    [SerializeField] private Canvas _ECanvas;
    [SerializeField] private AudioSource _AudioSource;

    private bool _hasPlayer;

    private void Update()
    {
        if (_hasPlayer == true && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(SoundPlay());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _ECanvas.gameObject.SetActive(true);
        _hasPlayer = true;
    }

    IEnumerator SoundPlay()
    {
        _AudioSource.Play();
        yield return new WaitForSeconds(2);
        _nextLevel.ChangeLevel();
    }
}
