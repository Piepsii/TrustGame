using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private string nextScene;

    private static int numberOfGoals = 2;

    private bool previous, active;

    void Update()
    {
        if (previous == false && active == true)
        {
            numberOfGoals--;
        }
        else if(previous == true && active == false)
        {
            numberOfGoals++;
        }
        previous = active;

        if(numberOfGoals <= 0)
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
    }
}
