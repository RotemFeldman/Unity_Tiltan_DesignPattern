namespace States
{
    public class Jump : IState
    {
        private bool _usedOnEnter;
        public void Update()
        {
            if(!_usedOnEnter)
                OnEnter();

            Player.Instance.CurrentState = new Fall();
        }

        void OnEnter()
        {
            var vel = Player.Instance.Rb.velocity;
            vel.y += 5;

            Player.Instance.Rb.velocity = vel;

            _usedOnEnter = true;
        }
    }
}