
using UnityEngine;

namespace States
{
    public class Idle : IState
    {
        public void Update()
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                Player.Instance.CurrentState = new Walking();
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

            if (Input.GetKey(KeyCode.S))
            {
                Player.Instance.CurrentState = new Duck();
            }
            
        }
    }
}