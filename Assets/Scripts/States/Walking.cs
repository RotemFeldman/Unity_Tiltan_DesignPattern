using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class Walking : IState
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Player.Instance.transform.Translate(new Vector3(-Player.Instance.Speed,0,0) * Time.deltaTime);
            return;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            Player.Instance.transform.Translate(new Vector3(Player.Instance.Speed,0,0) * Time.deltaTime);
            return;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            Player.Instance.CurrentState = new Jump();
            return;
        }

        if (Player.Instance.Rb.velocity.y < 0)
        {
            Player.Instance.CurrentState = new Fall();
            return;
        }
        
        Player.Instance.CurrentState = new Idle();
        
        
        
    }
}
