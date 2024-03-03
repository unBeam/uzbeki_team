using UnityEngine;

public class RingPhone : MonoBehaviour
{
    [SerializeField] private AudioSource _ringPhone;
    [SerializeField] private AnimLight _light;
    [SerializeField] private GameObject _triggerPhone;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _ringPhone.Play();
            _light.Light();
            _triggerPhone.gameObject.SetActive(true);  
        }
    }

    public void StopRing()
    {
        _ringPhone.Stop();
        _light.StopLight();
    }
}
