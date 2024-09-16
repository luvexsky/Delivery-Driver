using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   bool hasPackage;
 void OnCollisionEnter2D(Collision2D other)
 {
    Debug.Log("Ouch");
 }

 void OnTriggerEnter2D(Collider2D other)
 {
    if (other.tag == "Package" && !hasPackage)
    {
      Debug.Log("Package picked up");
      hasPackage = true;
      Destroy(other.gameObject, 0.5f);
    }
    if (other.tag == "Customer" && hasPackage) 
    {
      Debug.Log("Package delivered");
      hasPackage =  false;
    }
 }
}
