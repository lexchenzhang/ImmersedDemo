using System.Collections;
using System.Collections.Generic;
using com.Immersed.Lex.System.Position;
using UnityEngine;

namespace com.Immersed.Lex.Role
{
    public class Student : MonoBehaviour, IRole
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

        // Start is called before the first frame update
        void Start()
        {
            //for easy test
            uid = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.B))
            {
                Move();
            }
        }
    }
}