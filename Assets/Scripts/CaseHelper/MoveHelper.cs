using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace com.Immersed.Lex.Helper
{
    public class MoveHelper : MonoBehaviour
    {
        private GameObject[] seats;
        private NavMeshAgent _agent;

        void Awake()
        {
            Init();
        }

        public void Init()
        {
            _agent = GetComponent<NavMeshAgent>();
            seats = new GameObject[4];
            for(int i=0;i<4;i++) seats[i] = GameObject.Find("des" + i);
            StartCoroutine(MoveTo());
        }

        IEnumerator MoveTo()
        {
            while(true)
            {
                _agent.SetDestination(seats[Random.Range(0, 3)].transform.position);
                yield return new WaitForSeconds(3);
            }
        }
    }
}