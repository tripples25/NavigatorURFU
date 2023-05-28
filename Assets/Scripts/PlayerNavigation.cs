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
    [SerializeField] private NavMeshAgent navMeshAgent;
    private CharacterController charCont;
    private Vector3? destination;

    private void Awake()
    {
        charCont = GetComponent<CharacterController>();
        destinations = destinationsParent.GetComponentsInChildren<Transform>().Skip(1).ToDictionary(x => x.name);
    }
    
    void FixedUpdate()
    {
        ChangeNavigationMode();

        if (destination != null && Vector3.Distance(transform.position, destination.Value) <= 2)
        {
            navMeshAgent.ResetPath();
            destination = null;
        }
        
        DrawPath();
    }

    public void SetDestination()
    {
        if (!destinations.ContainsKey(inputField.text))
        {
            if (inputField.text[0] == '1' || inputField.text[0] == '2' || inputField.text[0] == '3' ||
                inputField.text[0] == '4')
                navMeshAgent.SetDestination(destinations["Лестница"].transform.position);
            else print("Ошибка в названии аудитории.");
            
            return;
        }
        navMeshAgent.SetDestination(destinations[inputField.text].transform.position);
        destination = destinations[inputField.text].transform.position;
    }

    public void MenToilet()
    {
        navMeshAgent.SetDestination(new Vector3(-37.2490005f,-9.46500015f,-46.1879997f));
    }

    public void WomanToilet()
    {
        navMeshAgent.SetDestination(destinations["Туалеты"].transform.position);
    }

    public void Deanery()
    {
        navMeshAgent.SetDestination(destinations["Деканат"].transform.position);
    }

    public void Coworking()
    {
        navMeshAgent.SetDestination(destinations["Коворкинг"].transform.position);
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
