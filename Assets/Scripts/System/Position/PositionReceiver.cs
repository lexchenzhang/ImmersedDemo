using UnityEngine;

namespace com.Immersed.Lex.System.Position
{
    public class PositionReceiver : MonoBehaviour
    {
        private void OnReceiveMovement(int uid, Transform _transform)
        {
            Debug.Log(uid + " moves at " + _transform);
        }
    }
}