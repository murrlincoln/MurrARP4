using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class OpenWyatt : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Replace "http://www.example.com" with the URL you want to open
        UnityEngine.Application.OpenURL("https://newsonline.library.vanderbilt.edu/2021/08/vanderbilts-historic-buildings-the-faye-and-joe-wyatt-center/");
    }
}

