using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button;
    public string playAnimation;
    public void Button_Touch()
    {
        button.GetComponent<Animation>().Play(playAnimation);
    }
}
