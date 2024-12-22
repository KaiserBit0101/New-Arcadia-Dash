using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalLinks : MonoBehaviour
{
    public void OpenItch()
    {
        Application.OpenURL("https://jimmyvegas.itch.io/timmy-mousey");
    }

    public void OpenPatreon()
    {
        Application.OpenURL("https://www.patreon.com/jimmyvegas");
    }

    public void OpenYouTube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCRMXHQ2rJ9_0CHS7mhL7erg");
    }

}
