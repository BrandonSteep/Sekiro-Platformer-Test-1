using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class ShieldDroidPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    [SerializeField]
    private EnemyStats Stats;
    public int patrolDestination;
    private int currentPatrolIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2
            .MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, Stats.GetSpeed() * Time.deltaTime);

        if(Vector2.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 1f) 
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }

    }
}
