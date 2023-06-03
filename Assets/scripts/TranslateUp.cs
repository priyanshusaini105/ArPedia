using UnityEngine;
using UnityEngine.UI;

public class TranslateUpOnClick : MonoBehaviour
{
    public RectTransform objectToTranslate;

    public void TranslateUp()
    {
        Vector2 newPosition = new Vector2(0f, 503f);
        objectToTranslate.anchoredPosition = newPosition;
    }
}
