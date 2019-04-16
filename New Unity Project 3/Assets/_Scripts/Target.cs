using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Target : MonoBehaviour {

    public float health = 400;
    public GameObject destroyedVersion;
    public Slider healthSlider;  
    // public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.

    public static float playerScore;
    public static bool isDead = false; 


    void OnGUI()
    {

        GUI.Label(new Rect(10, 10, 10000, 10000), "You killed " + (int)(playerScore) + "/50 Innocent objects");
    }

    public void Update()
    {
        //healthSlider.value = health;
    }

    public void TakeDamage (float amount)
    {

    health -= amount; 
        if (health <= 0f)
        {
            isDead = true;
            playerScore ++;
            ScoreManager.score = ScoreManager.score + (int)playerScore;
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
        Instantiate(destroyedVersion, transform.position, transform.rotation);
    }


}
