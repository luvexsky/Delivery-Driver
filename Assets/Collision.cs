using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
 void OnCollisionEnter2D(Collision2D other)
 {
    Debug.Log("Ouch");
 }

 void OnTriggerEnter2D(Collider2D other)
 {
    Debug.Log("What was that?!");
 }
}
