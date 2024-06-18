using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SilderExercise : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    private TextMeshProUGUI text;

    private void Awake()
    {
        slider.onValueChanged.AddListener(OnSliderEvent); 
    }

    public void OnSliderEvent(float value)
    {
        //text.text = $"Volume {value * 100:F1}%";
    }
}
