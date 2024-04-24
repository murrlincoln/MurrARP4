using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class OpenHomeEcon : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Replace "http://www.example.com" with the URL you want to open
        UnityEngine.Application.OpenURL("https://news.vanderbilt.edu/2020/09/02/vanderbilt-opens-new-buildings-in-west-end-and-peabody-neighborhoods/");
    }
}

