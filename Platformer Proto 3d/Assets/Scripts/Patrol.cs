using UnityEngine;

public class Patrol : MonoBehaviour
{
    public int currentPatrolPoint = 0;
    
    [Tooltip("The transform to which the enemy will pace back and forth to.")]
    public Transform[] patrolPoints;
    

    // Update is called once per frame
    public void Patrolling(float walkSpeed)
    {
        //Patrol Logic
        Vector3 moveToPoint = patrolPoints[currentPatrolPoint].position;
        transform.position = Vector3.MoveTowards(transform.position, moveToPoint, walkSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveToPoint) < 0.01f)
        {
            currentPatrolPoint++;
            if (currentPatrolPoint > patrolPoints.Length - 1)
            {
                currentPatrolPoint = 0;
            }
        }
        
      
    }
    
}
