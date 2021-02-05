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
        static int obj_counter { get; set; }
        private SpawnHelper _spawnHelper;
        private PositionData _positionData;

        // Start is called before the first frame update
        void Start()
        {
            InitCom();
            SetupScene();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void AddCounter()
        {
            obj_counter++;
        }

        private void InitCom()
        {
            _spawnHelper = GetComponent<SpawnHelper>();
            _positionData = GetComponent<PositionData>();
        }

        private void SetupScene()
        {
            GameObject prof = _spawnHelper.SpawnProfessor();
            RegisterEvents(prof);
            for (int i = 0; i < StudentNumer; i++)
            {
                GameObject student = _spawnHelper.SpawnStudent();
                RegisterEvents(student);
            }
        }

        private void RegisterEvents(GameObject obj)
        {
            IRole role = obj.GetComponent<IRole>();
            role.uid = obj_counter;
            _positionData.Add(role.uid, obj);
            foreach (KeyValuePair<int, GameObject> player in PositionData._playerDic)
            {
                if (player.Key == role.uid) continue;
                role.RegisterEvent(player.Value.GetComponent<IRole>());
            }
            AddCounter();
        }

    }
}
