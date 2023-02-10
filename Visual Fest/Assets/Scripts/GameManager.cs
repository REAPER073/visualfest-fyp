using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image logobg;
    public GameObject LogoScreen;
    public GameObject LoginScreen;
    public Button Gobtn, backbtn;


    float minAlphaValue = 0.0f;
    float maxAlphaValue = 1.0f;
    float speed = 1.0f;
    private bool increasing = true;

    // Start is called before the first frame update
    void Start()
    {
        Gobtn.onClick.AddListener(MainScreen);
        backbtn.onClick.AddListener(backbtnLog);
    }

    // Update is called once per frame
    void Update()
    {
        //Screen Animation Function Calling.
        Screenanimation();
    }
    public void Screenanimation()
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

    public void MainScreen()
    {
        LogoScreen.SetActive(false);
        LoginScreen.SetActive(true);
    }

    public void backbtnLog()
    {
        LogoScreen.SetActive(true);
        LoginScreen.SetActive(false);
    }
}
