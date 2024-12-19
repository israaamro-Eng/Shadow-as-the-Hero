using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName="";
    public int health;

    static public int playerCount=0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName=name;
        health=initialHealth;
    }

    public void Heal(int amount)
    {
        health= health+amount;
        Debug.Log("health =" + health);
    }

    public void Heal(bool fullRestore)
    {
       if(fullRestore==true)
       {
        health=100;
       }
    }

    static public void ShowPlayerCount()
    {
       Debug.Log("number of player=" + playerCount );
    }


}
