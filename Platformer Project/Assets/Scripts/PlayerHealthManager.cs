using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    private int health;
    public Text healthText;
    public GameObject loseGame;
    // Start is called before the first frame update
    void Start()
    {
        loseGame.SetActive(false);
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            loseGame.SetActive(true);
        }
        healthText.text = "Health: " + health.ToString();
    }
    public void changeHealth(int value)
    {
        health += value;
    }
}
