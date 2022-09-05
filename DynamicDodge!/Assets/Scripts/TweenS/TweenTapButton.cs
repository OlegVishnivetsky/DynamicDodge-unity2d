using UnityEngine;

public class TweenTapButton : MonoBehaviour
{
    [SerializeField] private float _animationSpeed;
    [SerializeField] private LeanTweenType _leanTweenType;

    void Start()
    {
        LeanTween.scale(gameObject, new Vector2(transform.localScale.x + 0.1f, transform.localScale.y + 0.1f), _animationSpeed).setEase(_leanTweenType).setLoopPingPong();
    }
}