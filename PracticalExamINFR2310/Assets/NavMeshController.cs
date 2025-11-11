using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;

    bool IsWalking;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }
    void Update()
    {

        agent.destination = Target.transform.position;

    }

    private void OnTriggerEnter(Collider other)      //if it hits the target
    {
        if (other.name == "Target")
        {
            IsWalking = false;
        }

        if(other.tag == "Axe")
        {
            Destroy(other.gameObject);
        }

        if(other.tag == "Sword")
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Target")
        {           
            IsWalking = true;
        }
    }

}
