using UnityEngine;
using UnityEngine.UI;

public class TweenBackgroundColor : MonoBehaviour
{
    [Header("Tween Settings")]
    [SerializeField] private float _animationSpeed;
    [SerializeField] private LeanTweenType _leanTweenType;

    private float _tweenValue;

    public void TweenToRedBackGround()
    {
        LeanTween.value(_tweenValue, 1, 0.2f).setOnComplete(() =>
        {
            gameObject.GetComponent<Image>().color = Color.red;
        });      
    }
}
