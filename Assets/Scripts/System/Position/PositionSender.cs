using UnityEngine;
using System;

namespace com.Immersed.Lex.System.Position
{
    public class PositionSender : MonoBehaviour
    {
        public event Action<int, Transform> OnPlayerMove;

        public void SyncMovement(int uid, Transform _transform)
        {
            OnPlayerMove(uid, _transform);
        }
    }
}