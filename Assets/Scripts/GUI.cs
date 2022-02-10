using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Must have to use Text Mesh Pro elements
using UnityEngine.UI; // Must have to program slider (and probably other things)

public class GUI : MonoBehaviour
{

    public TMP_Text planetName;
    //[Range (0,2)]
    public Slider slider;

    // Planet/Moon names
    

    void Start()
    {
        if (slider) slider.value = Time.timeScale;
    }

    void Update()
    {
 
        planetName.text = "Earth";
    }

    public void ButtonClicked()
    {
        print("BUTTON CLICKED");
    }

    public void SliderUpdated(float value)
    {
        Time.timeScale = value;
    }

    public void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        Debug.Log("Click Registered");
    }

}
