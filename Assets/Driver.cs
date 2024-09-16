using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   [SerializeField] float steerSpeed = 0.5f;
   [SerializeField] float moveSpeed = 0.01f;
   [SerializeField] float slowSpeed = 0.1f;
   [SerializeField] float boostSpeed = 35f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

void OnCollisionEnter2D(Collision2D other)
{
    moveSpeed = slowSpeed;

}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
