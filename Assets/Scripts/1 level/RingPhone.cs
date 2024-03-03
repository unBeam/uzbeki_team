using UnityEngine;

public class RingPhone : MonoBehaviour
{
    [SerializeField] private AudioSource _ringPhone;
    [SerializeField] private AnimLight _light;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _ringPhone.Play();
            _light.Light();
        }
    }

    public void StopRing()
    {
        _ringPhone.Stop();
        _light.StopLight();
    }
}
