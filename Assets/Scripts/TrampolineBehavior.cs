using System;
using UnityEngine;

public class TrampolineBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    { 
       rb = collision.gameObject.GetComponent<Rigidbody2D>();
       rb.AddForce(GameParameters.trampolineForce * Vector2.up, ForceMode2D.Impulse);
    }
}
