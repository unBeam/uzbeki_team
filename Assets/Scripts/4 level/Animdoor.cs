using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animdoor : MonoBehaviour
{
    private readonly int _openDoor = Animator.StringToHash("Checkcard");

    [SerializeField] private Animator _open;

    public void OpeningDoor()
    {
        _open.SetTrigger(_openDoor);
    }
}
