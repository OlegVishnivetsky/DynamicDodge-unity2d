using UnityEngine;

public class TweenTransitionScene : MonoBehaviour
{
    [SerializeField] private bool _isTransitionIn = true;
    [SerializeField] private LeanTweenType _transitionTweenType;

    private void Start()
    {
        if (_isTransitionIn)
            TransitionInScene();
        else
            TransitionOutScene();
    }

    private void TransitionInScene()
    {
        LeanTween.moveLocalX(gameObject, 0, 1).setEase(_transitionTweenType);
    }

    private void TransitionOutScene()
    {
        LeanTween.moveLocalX(gameObject, -2500, 1).setEase(_transitionTweenType).setDestroyOnComplete(true);
        
    }
}
