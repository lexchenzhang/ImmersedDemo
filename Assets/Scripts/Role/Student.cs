using com.Immersed.Lex.System.Data;
using com.Immersed.Lex.System.Position;
using com.Immersed.Lex.System.Utils;
using UnityEngine;

namespace com.Immersed.Lex.Role
{
    public class Student : MonoBehaviour, IRole
    {
        private PositionSender _positionSender;
        private PositionData _positionData;

        public int uid { get; set; }

        public void Move()
        {
            _positionSender.SyncMovement(uid, transform);
        }

        public void RegisterEvent(GameObject other)
        {
            _positionSender.OnPlayerMove += other.GetComponent<PositionReceiver>().OnReceiveMovement;
        }

        public void Talk()
        {
            
        }

        public void Init()
        {
            _positionSender = GetComponent<PositionSender>();
            _positionData = GetComponent<PositionData>();
        }

        public void SetVisible(int _uid, Transform _trans)
        {
            GameObject obj = _positionData.GetObjByUID(_uid);
            Material _mat = GetComponent<Renderer>().material;
            Color _color = _mat.color;
            _mat.SetColor("_Color", new Color(_color.r, _color.g, _color.b, transform.position.IsBehind(_trans.position) ? 0.1f : 1f));
        }

        void Awake()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {
            Move();
        }
    }
}