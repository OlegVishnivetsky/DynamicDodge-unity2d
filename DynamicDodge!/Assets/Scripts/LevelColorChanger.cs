using UnityEngine;
//using UnityEngine.Rendering.PostProcessing;

public class LevelColorChanger : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Material _playerTrailMaterial;
    //[SerializeField] private PostProcessVolume _postProcessVolume;
    [SerializeField] private SpriteRenderer _treatSpriteRenderer;
    [Header("Colors")]
    [SerializeField] private Color32[] _availableColors = { new Color32(206, 212, 0, 255), new Color32(212, 151, 0, 255),  new Color32(212, 0, 16, 255) };
    private Color32 _playerDefaultTrailColor = Color.cyan;
    //private Bloom _bloom;

    private void Start()
    {
        _playerTrailMaterial.color = _playerDefaultTrailColor;
        //_bloom = _postProcessVolume.profile.GetSetting<Bloom>();
    }

    public void ChangeRandomColor()
    {
        Color randomColor = _availableColors[Random.Range(0, _availableColors.Length - 1)];

        //_bloom.color.Override(randomColor);
        _playerTrailMaterial.color = randomColor;
        _treatSpriteRenderer.color = randomColor;
    }
}