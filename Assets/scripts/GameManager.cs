using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("israa" , 60);
        player2.InitializePlayer("amro" , 80);

        Debug.Log(player1.playerName);

        player1.Heal(20);

        player2.Heal(true);
        Debug.Log(player2.playerName + " " + "health" + " " + player2.health);

        
    }

}
