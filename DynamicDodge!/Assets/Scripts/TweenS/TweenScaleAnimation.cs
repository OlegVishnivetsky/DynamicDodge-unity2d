using UnityEngine;

public class TweenScaleAnimation : MonoBehaviour
{
    [Header("Tween Settings")]
    [Header("Float Values")]
    [SerializeField] private float _scaleInTime = 0.5f;
    [SerializeField] private float _scaleOutTime;
    [SerializeField] private float _defaultScaleValue = 1.0f;
    [Header("Other Tween Settings")]
    [SerializeField] private bool _isPlayOnAwake = false;
    [SerializeField] private bool _isScaleOut = false;
    [SerializeField] private LeanTweenType _leanTweenType;

    private void Start()
    {
        if (_isPlayOnAwake)
            TweenScaleIn();

        if (_isPlayOnAwake && _isScaleOut)
            TweenScaleOut();

    }

    public void TweenScaleIn()
    {
        transform.localScale = Vector2.zero;
        LeanTween.scale(gameObject, new Vector2(_defaultScaleValue, _defaultScaleValue), _scaleInTime).setEase(_leanTweenType);
    }

    public void TweenScaleOut()
    {
        LeanTween.scale(gameObject, Vector2.zero, _scaleOutTime).setEase(_leanTweenType);
    }
}
