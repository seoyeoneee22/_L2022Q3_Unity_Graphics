using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Button : MonoBehaviour
{
    public InputField InputFieldComponent;
    public Text TextComponent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick_SetText()
    {
        string input = InputFieldComponent.text;
        TextComponent.text = input;
    }
}
