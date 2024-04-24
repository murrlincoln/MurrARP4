using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class OpenWilson : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Replace "http://www.example.com" with the URL you want to open
        UnityEngine.Application.OpenURL("https://news.vanderbilt.edu/2020/07/29/script-change-the-road-to-hollywood-is-sometimes-paved-through-wilson-hall/");
    }
}

