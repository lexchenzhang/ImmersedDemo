using System.Collections;
using UnityEngine;

namespace com.Immersed.Lex.FSM
{
    public class StateTrans : MonoBehaviour
    {
        public void ChangeTo(IState prev, IState next, float delay)
        {
            StartCoroutine(Exec(prev, next, delay));
        }

        private IEnumerator Exec(IState prev, IState next, float delay)
        {
            yield return new WaitForSeconds(delay);
            next?.OnEnter();
            prev?.OnExit();
        }
    }
}