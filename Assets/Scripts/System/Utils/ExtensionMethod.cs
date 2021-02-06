using UnityEngine;
using UnityEngine.AI;

namespace com.Immersed.Lex.System.Utils
{
    public static class ExtensionMethods
    {
        public static float GetPathRemainingDistance(this NavMeshAgent navMeshAgent)
        {
            if (navMeshAgent.pathPending ||
                navMeshAgent.pathStatus == NavMeshPathStatus.PathInvalid ||
                navMeshAgent.path.corners.Length == 0)
                return -1f;

            float distance = 0.0f;
            for (int i = 0; i < navMeshAgent.path.corners.Length - 1; ++i)
            {
                distance += Vector3.Distance(navMeshAgent.path.corners[i], navMeshAgent.path.corners[i + 1]);
            }

            return distance;
        }

        public static bool IsBehind(this Vector3 queried, Vector3 forward)
        {
            return Vector3.Dot(queried, forward) < 0f;
        }

        public static bool IsVisible(this Vector3 src_v, Vector3 des_v, Vector3 forward, float angle)
        {
            float _cosAngle = Vector3.Dot((des_v - src_v).normalized, forward);
            float _angle = Mathf.Acos(_cosAngle) * Mathf.Rad2Deg;
            return _angle < angle;
        }
    }
}