using UnityEngine;
//using UnityEngine.Rendering.PostProcessing;

public class BloomSettings : MonoBehaviour
{
    [SerializeField] private bool isBloomActive;
    //[SerializeField] private PostProcessVolume _processVolume;

    private void Start()
    {
        //_processVolume.enabled = PlayerPrefs.GetInt("IsBloomActive") == 1;
        isBloomActive = PlayerPrefs.GetInt("IsBloomActive") == 1;
    }

    public void ToggleBloomControl()
    {
        isBloomActive = !isBloomActive;
        //_processVolume.enabled = isBloomActive;
        if(isBloomActive)
           PlayerPrefs.SetInt("IsBloomActive", 1);
        else
            PlayerPrefs.SetInt("IsBloomActive", 0);
    }
}