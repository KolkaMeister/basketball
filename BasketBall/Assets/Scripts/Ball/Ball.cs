using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rigidbody;


    private bool isTaken;

    public bool IsTaken => isTaken;

    public void Throw(Vector2 force)
    {
        isTaken = false;
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }

    public void Stop()
    {
        _rigidbody.bodyType = RigidbodyType2D.Kinematic;
        ZeroVelocity();
        isTaken = true;
    }
    public void ZeroVelocity()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0;
    }
}
