using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private Transform ballHoldPosition;
    [SerializeField] private Transform basketPosition;

    private Ball ball;

    private void Throw()
    {
        if (ball == null) return;
        var direction = basketPosition.position - ballHoldPosition.position;
        ball.Throw(direction);
        
    }

    private void TakeBall(Ball _ball)
    {
        ball = _ball;
        ball.Stop();
        ball.transform.parent = ballHoldPosition;
        ball.transform.position = ballHoldPosition.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("2131");
        var _ball = collision.gameObject.GetComponent<Ball>();
        if (_ball == null) return;
        if (_ball.IsTaken) return;
        TakeBall(_ball);
    }
}
