using UnityEngine;
using UnityEngine.AI;

namespace Assets.Scripts
{
    class PlayerMoveController : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent Agent;

        RaycastHit Hit = new RaycastHit();

        public void Update()
        {
            if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray.origin, ray.direction, out Hit))
                    Move(Hit.point);
                NavMeshTriangulation navMeshTriangulation = new NavMeshTriangulation();
            }
        }

            private void Move(Vector3 dest)
        {
            Agent.SetDestination(dest);
        }
    }
}
