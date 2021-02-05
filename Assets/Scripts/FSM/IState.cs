namespace com.Immersed.Lex.FSM
{
    public interface IState
    {
        int m_val { get; set; }
        void OnEnter();
        void OnExit();
    }
}