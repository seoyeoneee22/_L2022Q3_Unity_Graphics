using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Slider : MonoBehaviour
{
    public GameObject MyGameObject;
    Material MyMaterial;


    // Start is called before the first frame update
    void Start()
    {
        MyMaterial = MyGameObject.GetComponent<Renderer>().material;
       // Color c = new Color(1, 0, 0, 1);
       // MyMaterial.SetColor("_Color", c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged_SetColor()
    {
        float f = GetComponent<Slider>().value;
        Color c = new Color(f, f, f, f);
        MyMaterial.SetColor("_Color", c);
    }
}
