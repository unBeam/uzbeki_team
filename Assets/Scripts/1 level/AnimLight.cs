using UnityEngine;

public class AnimLight : MonoBehaviour
{
    private readonly int _redLightAnim = Animator.StringToHash("Light");
    private readonly int _stopLightAnim = Animator.StringToHash("Stop");

    [SerializeField] private Animator _lightAnimator;

    public void Light()
    {
        _lightAnimator.SetTrigger(_redLightAnim);
    }

    public void StopLight()
    {
        _lightAnimator.SetTrigger(_stopLightAnim);
    }
}
