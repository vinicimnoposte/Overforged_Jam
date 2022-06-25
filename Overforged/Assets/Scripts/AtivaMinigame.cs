using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaMinigame : MonoBehaviour
{
    #region Variaveis
    public int Thispuzzle;
    public int Nopuzzle = 0;
    public GameObject player;
    public bool start;
    #endregion

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player") //&& Input.GetKeyDown("e"))
        {
            start = true;
            //collision.gameObject.SendMessage("SetStarter", Thispuzzle);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<CharacterBhvr>().SetStarter(Nopuzzle);
            player.GetComponent<CharacterBhvr>().resetPuzzle();
            start = false;
            //collision.gameObject.SendMessage("resetPuzzle");
            //collision.gameObject.SendMessage("SetStarter", Nopuzzle);
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown("e") && start)
        {
            player.GetComponent<CharacterBhvr>().SetStarter(Thispuzzle);
        }
    }
}
