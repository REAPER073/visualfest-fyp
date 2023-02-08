using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoScreen : MonoBehaviour
{
    public Image logobg;
    public float alphaValue = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        if (logobg == null)
        {
            Debug.LogError("Image component not assigned!");
            return;
        }

        Color tempColor = logobg.color;
        tempColor.a = alphaValue;
        logobg.color = tempColor;

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
