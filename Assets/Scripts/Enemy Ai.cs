// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// //https://www.youtube.com/watch?v=UjkSFoLxesw
// public class EnemyAi : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public NavMeshAgent agent;
//    //GameObject player = GameObject.FindWithTag("Player");
//     public Transform Player;
//     public LayerMask whatIsGround, whatIsPlayer;

//     //Patrol
//     public Vector3 walkPoint;
//     bool walkPointSet;
//     public float walkPointRange;

//     //Attack
//     public float timeBetweenAttacks;
//     bool already attacked

//     //states
//     public float sightRange, attackRange;
//     public bool playerInSightRange, playerInAttackRange;

//     private void Awake()
//     {
//         player = GameObject.Find("Player").transform;
//         agent = GetComponent<NavMeshAgent>();
//     }

//     private void Update()
//     {
//         playerInSightRange= Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
//         playerInAttackRange= Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

//         if (!playerInSightRange && !playerInAttackRange) Patrolling();
//         if (playerInAttackRange && !playerInAttackRange) ChasePlayer();
//         if (playerInAttackRange && playerInSightRange) AttackPlayer();
//     }
//     private void Patrolling()
//     {
//         if (!walkPointSet) SearchwalkPoint();
//         if (walkPointSet)
//             agent.SetDestination(walkpoint);
//         Vector3 distanceToWalkPoint= transform.position - walkpoint;
//         //walkpoint reached
//         if (distanceToWalkPoint.magnnitude < 1f)
//         walkPointSet = false;
//     }
//     private void SearchwalkPoint()
//     [
//         //laske satunnainen kavelypiste
//         float randomZ = Random.Range(-walkPointRange, walkPointRange);
//         float randomX = Random.Range(-walkPointRange, walkPointRange);

//         walkPoint = new Vector3(transform.position.x +randomX, transform.position.y, transform.position.z ++ randomZ);

//         if (Physics.Raycast(walkPoint,-transform.up, 2f, whatIsGround))
//         walkPointSet=True;
//     ]
//     private void ChasePlayer()
//     {
//         agent.SetDestination(player.position);
//     }
//     private void AttackPlayer()
//     {
//         agent.SetDestination(transform.position);

//         trandorm.LookAt(player);

//         if (!alreadyAttacked)
//         {

//             //Attack code HERE!
            
//             alreadyAttacked = True;
//             Invoke(nameof(ResetAtttack), timeBetweenAttacks);
//         }
//     }
//     private void ResetAtttack()
//     [
//         alreadyAttacked = false;
//     ]
// }
