using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarSkillCheck : MonoBehaviour
{
    #region Variaveis
    GameObject handle;
    public GameObject puzzleCheck;
    private RectTransform rectTransform;
    public float HorizontalSpeed = 1;
    public float MaxHorizontalPosition = 150;
    public float MinHorizontalPosition = 0;
    public bool vai = true;
    public bool space = false;
    public GameObject player;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        handle = GameObject.FindGameObjectWithTag("Handle");
        handle.GetComponent<RectTransform>();
        rectTransform = handle.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 position = rectTransform.anchoredPosition;
        if(position.x >= 0f && position.x < 150f && vai == true)
        {
            position.x += HorizontalSpeed * Time.deltaTime;     
        }
        if (position.x >= 150f)
        {
            vai = false;
        }
        if(vai == false)
            position.x -= HorizontalSpeed * Time.deltaTime;
        if (position.x <= 0f)
        {
            vai = true;
            position.x = 0f;
        }
        if (Input.GetKeyDown("space") && space)
        {
            //HorizontalSpeed = 0;
            print("sucesso");
            puzzleCheck.SetActive(false);
            player.GetComponent<CharacterBhvr>().minigamefinished = true;
        }
        if (Input.GetKeyDown("space") && !space)
        {
            print("falha");
            //HorizontalSpeed = 0;
            position.x = 0f;
        }
        rectTransform.anchoredPosition = position;

        if (puzzleCheck.activeInHierarchy)
        {
            player.GetComponent<CharacterBhvr>().enabled = false;
        }
        else
        {
            player.GetComponent<CharacterBhvr>().enabled = true;
        }
   
    }
    
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        space = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        space = false;
    }
}
