using UnityEngine;

namespace com.Immersed.Lex.Role
{
    public interface IRole
    {
        int uid { get; set; }
        string name { get; set; }

        void Init();
        void Move();
        void Talk();
        void SetVisible(int uid, Transform trans);
        void RegisterEvent(GameObject other);
    }
}