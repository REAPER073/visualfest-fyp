using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoScreen : MonoBehaviour
{
    public Image logobg;
    public float minAlphaValue = 0.0f;
    public float maxAlphaValue = 1.0f;
    public float speed = 1.0f;
    private bool increasing = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color tempColor = logobg.color;
        float currentAlpha = tempColor.a;

        if (increasing)
        {
            currentAlpha += Time.deltaTime * speed;
            if (currentAlpha >= maxAlphaValue)
            {
                increasing = false;
                currentAlpha = maxAlphaValue;
            }
        }
        else
        {
            currentAlpha -= Time.deltaTime * speed;
            if (currentAlpha <= minAlphaValue)
            {
                increasing = true;
                currentAlpha = minAlphaValue;
            }
        }

        tempColor.a = currentAlpha;
        logobg.color = tempColor;
    }

}