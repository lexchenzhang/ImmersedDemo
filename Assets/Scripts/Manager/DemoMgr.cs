using UnityEngine;
using com.Immersed.Lex.Helper;
using com.Immersed.Lex.Role;
using com.Immersed.Lex.System.Data;
using System.Collections.Generic;

namespace com.Immersed.Lex.Manager
{
    public class DemoMgr : MonoBehaviour
    {
        [Range (0, 100)]
        public int StudentNumer;
        private static int ObjCounter { get; set; }
        private SpawnHelper _spawnHelper;
        private PositionData _positionData;

        // Start is called before the first frame update
        void Start()
        {
            InitCom();
            SetupScene();
        }

        private void AddCounter()
        {
            ObjCounter++;
        }

        private void InitCom()
        {
            _spawnHelper = GetComponent<SpawnHelper>();
            _positionData = GetComponent<PositionData>();
        }

        private void SetupScene()
        {
            GameObject prof = _spawnHelper.SpawnProfessor();
            AddToDic(prof);
            for (int i = 0; i < StudentNumer; i++)
            {
                GameObject student = _spawnHelper.SpawnStudent();
                AddToDic(student);
                student.GetComponent<IRole>().RegisterEvent(prof);
            }
        }

        private void AddToDic(GameObject obj)
        {
            IRole role = obj.GetComponent<IRole>();
            role.uid = ObjCounter;
            _positionData.Add(role.uid, obj);
            AddCounter();
        }

    }
}
