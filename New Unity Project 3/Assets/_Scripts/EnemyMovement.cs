using UnityEngine;
using System.Collections;
using UnityEngine.AI; 

public class EnemyMovement : MonoBehaviour
{

    public GameObject obj;
    GameObject oldobj;

    public static EnemyMovement instance;         //A reference to our game control script so we can access it statically.

    public static bool alarmed = false; 

    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.


    //wandering 
    public float wanderRadius = 100f;
    public float wanderTimer = 10f;

    private Transform target;
    private float timer;

    // Use this for initialization
    void OnEnable()
    {
        timer = wanderTimer;
    }

    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        // If the enemy and the player have health left...
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            if (alarmed)
            {
                // ... set the destination of the nav mesh agent to the player.
                nav.SetDestination(player.position);
            }
            else
            {
                timer += Time.deltaTime;

                if (timer >= wanderTimer)
                {
                    Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                    nav.SetDestination(newPos);
                    timer = 0;
                    Destroy(oldobj);
                    oldobj = (GameObject)Instantiate(obj, newPos, transform.rotation);
                    oldobj.name = "Bob the crate";
                }
            }
        }

        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}