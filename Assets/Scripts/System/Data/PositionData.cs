using System.Collections.Generic;
using UnityEngine;

namespace com.Immersed.Lex.System.Data
{
    public class PositionData : MonoBehaviour
    {
        public static Dictionary<int, GameObject> _playerDic = new Dictionary<int, GameObject>();

        public void Add(int _uid, GameObject _obj)
        {
            _playerDic.Add(_uid, _obj);
        }

        public void UpdateElement(int _uid, GameObject _obj)
        {
            _playerDic[_uid] = _obj;
        }

        public GameObject GetObjByUID(int _uid)
        {
            return _playerDic[_uid];
        }
    }
}