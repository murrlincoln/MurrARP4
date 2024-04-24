using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class OpenOwenSign : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Replace "http://www.example.com" with the URL you want to open
        UnityEngine.Application.OpenURL("https://business.vanderbilt.edu/");
    }
}

