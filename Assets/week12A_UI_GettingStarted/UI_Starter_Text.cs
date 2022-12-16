using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Text : MonoBehaviour
{
    public GameObject MyGameObject;
    // Start is called before the first frame update
    void Start()
    {
        string name = MyGameObject.name;
        GetComponent<Text>().text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
