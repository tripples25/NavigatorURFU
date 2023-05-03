using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavigation : MonoBehaviour
{
    [SerializeField] private GameObject destinationsParent;
    [SerializeField] private TMP_InputField inputField;
    private Dictionary<string, Transform> destinations;
    private NavMeshAgent navMeshAgent;
    private CharacterController charCont;
    private Vector3? destination;
    public GameObject Panel;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        charCont = GetComponent<CharacterController>();
        destinations = destinationsParent.GetComponentsInChildren<Transform>().Skip(1).ToDictionary(x => x.name);
    }

    private void Start()
    {
        foreach (var (name, trans) in destinations)
        {
            var pan = Instantiate(Panel, trans, false);
            pan.transform.name = "РИ-" + name;
        }
    }

    void FixedUpdate()
    {
        if (destination.HasValue)
            navMeshAgent.SetDestination(destination.Value);

        ChangeNavigationMode();

        if (!navMeshAgent.hasPath)
            navMeshAgent.ResetPath();
        
        DrawPath();
    }

    public void SetDestination()
    {
        if (!destinations.ContainsKey(inputField.text))
        {
            print("Ошибка в названии аудитории.");
            return;
        }
        navMeshAgent.SetDestination(destinations[inputField.text].transform.position);
    }
    
    public void SetStartPoint(TMP_InputField input)
    {
        if (!destinations.ContainsKey(input.text))
        {
            print("Ошибка в названии аудитории.");
            return;
        }
        navMeshAgent.Warp(destinations[input.text].position);
    }

    private void ChangeNavigationMode()
    {
        PlayerMovement.instance.enabled = PlayerMovement.instance.joystick.Direction != Vector2.zero;
        navMeshAgent.updateRotation = Look.instance.joystick.Direction == Vector2.zero;
    }

    void DrawPath()
    {
 
        var nav = GetComponent<NavMeshAgent>();
        if( nav == null || nav.path == null )
            return;
 
        var line = this.GetComponent<LineRenderer>();
        if( line == null )
        {
            line = this.gameObject.AddComponent<LineRenderer>();
            line.material = new Material( Shader.Find( "Sprites/Default" ) ) { color = Color.yellow };
            line.SetWidth( 0.5f, 0.5f );
            line.SetColors( Color.yellow, Color.yellow );
        }
 
        var path = nav.path;
 
        line.SetVertexCount( path.corners.Length );
 
        for( int i = 0; i < path.corners.Length; i++ )
        {
            line.SetPosition( i, path.corners[ i ] );
        }
 
    }
}
