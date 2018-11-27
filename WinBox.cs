using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour {

private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Main Camera").SendMessage("Finnish");
       // GameObject.Find("Main Camera Right").SendMessage("Finnish");
    }
  
}
