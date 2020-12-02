using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehariour : MonoBehaviour
{
    public int health;
    private int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = health;
    }

    void TakeDamage(int damagetodeal)
    {
        currenthealth -= damagetodeal;

        if(currenthealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
