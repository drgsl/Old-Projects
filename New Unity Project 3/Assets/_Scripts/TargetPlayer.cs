using UnityEngine;

public class TargetPlayer : MonoBehaviour
{

    public float health = 50f;
    public GameObject destroyedVersion;


    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Debug.Log("GAME OVER");
        }
    }
    void Die()
    {
        FindObjectOfType<GameManager>().EndGame(); 
    }
}
