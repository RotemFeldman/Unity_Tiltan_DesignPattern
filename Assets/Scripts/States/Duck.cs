using UnityEngine;

namespace States
{
    public class Duck : IState
    {
        private bool _usedOnEnter;
        private Vector3 originalVec;
        private Vector3 vec;
        
        public void Update()
        {
            if(!_usedOnEnter)
                OnEnter();

            if (!Input.GetKey(KeyCode.S))
            {
                Player.Instance.transform.localScale = originalVec;
                Player.Instance.CurrentState = new Idle();
            }
            
        }

        void OnEnter()
        {
            vec = Player.Instance.transform.localScale;
            originalVec = vec;
            vec.y /= 2;

            Player.Instance.transform.localScale = vec;
            _usedOnEnter = true;
        }
    }
}