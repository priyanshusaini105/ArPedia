using UnityEngine;
using UnityEngine.UI;

public class TranslateDownOnClick : MonoBehaviour
{
    public GameObject objectToTranslate;
    public Button downButton;
    public float translationDistance = 50f;

    void Start()
    {
        downButton.onClick.AddListener(TranslateDown);
    }

    void TranslateDown()
    {
        objectToTranslate.transform.Translate(Vector3.down * translationDistance);
    }
}
