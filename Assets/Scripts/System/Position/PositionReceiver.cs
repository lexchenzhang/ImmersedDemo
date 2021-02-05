using com.Immersed.Lex.Role;
using UnityEngine;

namespace com.Immersed.Lex.System.Position
{
    public class PositionReceiver : MonoBehaviour
    {
        public void OnReceiveMovement(int _uid, Transform _transform)
        {
            this.GetComponent<IRole>().SetVisible(_uid, _transform);
        }
    }
}