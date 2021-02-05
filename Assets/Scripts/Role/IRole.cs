namespace com.Immersed.Lex.Role
{
    public interface IRole
    {
        int uid { get; set; }
        string name { get; set; }

        void RegisterEvent(IRole other);
        void Move();
        void Talk();
    }
}