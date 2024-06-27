namespace States
{
    public class Fall : IState
    {
        public void Update()
        {
            if (Player.Instance.Rb.velocity.y == 0f)
            {
                Player.Instance.CurrentState = new Idle();
            }
        }
    }
}