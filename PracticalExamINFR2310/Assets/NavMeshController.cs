using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NavMeshController : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;
    public GameObject Sword;
    public GameObject Axe;

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

        if (other.name == ("Axe"))
        {
            Destroy(Axe);
            Debug.Log("Obtained Axe");
        }

        if (other.name == ("Sword"))
        {
            Destroy(Sword);
            Debug.Log("Obtained Sword");
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
