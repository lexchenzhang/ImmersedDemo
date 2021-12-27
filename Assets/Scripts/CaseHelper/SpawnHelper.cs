using com.Immersed.Lex.Role;
using UnityEngine;

namespace com.Immersed.Lex.Helper
{
    public class SpawnHelper : MonoBehaviour
    {
        [SerializeField] [Range(1, 5)] private float _genOffset;
        [SerializeField] private GameObject _professorPrefab;
        [SerializeField] private GameObject _studentPrefab;

        public GameObject SpawnProfessor()
        {
            GameObject prof = Instantiate(_professorPrefab,
                new Vector3(0, .25f, 0),
                Quaternion.identity);
            return prof;
        }

        public GameObject SpawnStudent()
        {
            GameObject student = Instantiate(_studentPrefab,
                new Vector3(Random.Range(_genOffset, -_genOffset), .25f, Random.Range(_genOffset, -_genOffset)),
                Quaternion.identity);
            return student;
        }
    }
}