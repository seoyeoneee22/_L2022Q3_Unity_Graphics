using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Play(); //����� �÷��� ����ض�
    }

    // Update is called once per frame
    void Update()
    {
        //Ű���� �����ؼ� p������ ���, s������ ����
        if (Input.GetKeyDown(KeyCode.P))
        {
            Audio.Play();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Audio.Stop();
        }
    }
}
