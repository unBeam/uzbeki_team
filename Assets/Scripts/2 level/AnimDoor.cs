using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDoor : MonoBehaviour
{
    private readonly int _openDoor = Animator.StringToHash("Open");

    [SerializeField] private Animator _open;

    public void OpeningDoor()
    {
        _open.SetTrigger(_openDoor);
    }
}
