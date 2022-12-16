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
        Audio.Play(); //오디오 플레이 재생해라
    }

    // Update is called once per frame
    void Update()
    {
        //키보드 감지해서 p누르면 재생, s누르면 멈춤
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
