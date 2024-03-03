using System.Collections;
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
            StartCoroutine(RingingPhone());
        }
    }

    public void StopRing()
    {
        _ringPhone.Stop();
        _light.StopLight();
    }

    IEnumerator RingingPhone()
    {
        yield return new WaitForSeconds(3);
        _ringPhone.Play();
        _light.Light();
        _triggerPhone.gameObject.SetActive(true);

    }
}
