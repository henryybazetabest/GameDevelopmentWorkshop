using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyAlpha : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject redUIButton;
    public GameObject yellowUIButton;
    public GameObject blueUIButton;

    void Update()
    {
        if (gameManager.GetComponent<WorldColour>().isRed)
        {
            redUIButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            redUIButton.GetComponent<Image>().color = Color.gray;
        }

        if (gameManager.GetComponent<WorldColour>().isYellow)
        {
            yellowUIButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            yellowUIButton.GetComponent<Image>().color = Color.gray;
        }

        if (gameManager.GetComponent<WorldColour>().isBlue)
        {
            blueUIButton.GetComponent<Image>().color = Color.white;
        }
        else
        {
            blueUIButton.GetComponent<Image>().color = Color.gray;
        }
    }
}
