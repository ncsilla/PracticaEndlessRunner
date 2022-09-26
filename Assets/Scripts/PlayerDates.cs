using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerDates
{
    public float[] pos;
    public int coins;
    public int position;

    public PlayerDates(PlayerController player)
    {
        coins = player.coins;
        position = (int)player.position;
        Debug.Log(position);
    }

}