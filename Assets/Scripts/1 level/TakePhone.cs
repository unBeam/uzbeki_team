using UnityEngine;

public class TakePhone : MonoBehaviour
{
    [SerializeField] private RingPhone _ring;
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _ringTrigger;

    private bool _playerOnTrigger;

    private void Update()
    {
        if( _playerOnTrigger == true && Input.GetKey(KeyCode.E))
        {
            _ring.StopRing();
            _talk.StartTalking();
            _ringTrigger.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _playerOnTrigger = true;
        }
    }
}
