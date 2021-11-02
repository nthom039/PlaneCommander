using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lives : MonoBehaviour
{
    public GameObject[] livesGO;
    public int livesLost = 0;

    public void LoseLive()
    {
        if(livesLost == 4)
        {
            SceneManager.LoadScene("Loser");
        }
        else
        {
            livesGO[livesLost].SetActive(false);
        }
        livesLost ++;
    }
}
