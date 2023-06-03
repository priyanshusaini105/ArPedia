using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrls : MonoBehaviour
{
    public string url;
   public void openUrl()
    {
        Application.OpenURL(url);
    }
}
