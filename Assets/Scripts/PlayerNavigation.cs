using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavigation : MonoBehaviour
{
    [SerializeField] private GameObject destinationsParent;
    private Dictionary<string, Transform> destinations;
    private NavMeshAgent navMeshAgent;
    private CharacterController charCont;

    public static bool isControlledByPlayer = false;
    
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        charCont = GetComponent<CharacterController>();
        destinations = destinationsParent.GetComponentsInChildren<Transform>().Skip(1).ToDictionary(x => x.name);
    }

    void Start()
    {
        navMeshAgent.SetDestination(destinations["431"].transform.position);
    }
    
    void Update()
    {
        if (isControlledByPlayer)
            DisableNavigation();
        else
            EnableNavigation();
    }

    private void DisableNavigation()
    {
        navMeshAgent.updatePosition = false;
        navMeshAgent.updateRotation = false;
        navMeshAgent.velocity = charCont.velocity;
        PlayerMovement.instance.enabled = true;
    }
    
    private void EnableNavigation()
    {
        navMeshAgent.updatePosition = true;
        navMeshAgent.updateRotation = true;
        PlayerMovement.instance.enabled = false;
    }
}
