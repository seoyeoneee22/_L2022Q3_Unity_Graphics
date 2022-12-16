using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Control : MonoBehaviour
{
    public GameObject Pivot;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name + " enter");
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        print(other.name + " exit");
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }

 }
