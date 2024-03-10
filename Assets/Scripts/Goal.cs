using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public bool Player1Goal = true;
    public TextMeshProUGUI scorebox;
    public static int player1Score = 0;
    public static int player2Score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player1Goal)
        {
            player2Score++;
        }
        else
        {
            player1Score++;
        }
        scorebox.text = $"{player1Score}:{player2Score}";
    }
}
