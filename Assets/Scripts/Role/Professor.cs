using UnityEngine;
using com.Immersed.Lex.System.Position;

namespace com.Immersed.Lex.Role
{
    public class Professor : MonoBehaviour, IRole
    {
        private PositionSender _positionSender;

        public int uid { get; set; }
        
        public void Move()
        {
            _positionSender.SyncMovement(uid, transform);
        }

        public void RegisterEvent(IRole other)
        {
            
        }

        public void Talk()
        {
            
        }

        private void Init()
        {
            _positionSender = GetComponent<PositionSender>();
        }

        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Move();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, .5f);
        }
    }
}