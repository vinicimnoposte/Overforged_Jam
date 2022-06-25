using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skillcheck : MonoBehaviour
{
    #region Variaveis
    GameObject player;
    public GameObject shrekpai;
    public GameObject fionapai;
    public Image shrek;
    public Image fiona;
    public float carrega = 0;
    public bool coolingDownS = false;
    public bool coolingDownF;
    public float waitTime = 10.0f;
    public float sobe;
    public bool pressA;
    public bool pressD;
    #endregion
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if(coolingDownS == true)
        {
            shrek.fillAmount -= 1.0f / waitTime * Time.deltaTime;
        }
        if (Input.GetKeyDown("space"))
        {
            coolingDownS = true;
            shrek.fillAmount += sobe;
        }
        if(shrek.fillAmount == 1)
        {
            coolingDownS = false;
            
            shrekpai.SetActive(false);
        }
        
        
        if(Input.GetKeyDown("a") && !pressA)
        {
            pressA = true;
            pressD = false;
            coolingDownF = true;
            fiona.fillAmount += sobe;
        }
        if(Input.GetKeyDown("d") && !pressD)
        {
            pressA = false;
            pressD = true;
            coolingDownF = true;
            fiona.fillAmount += sobe;
        }
        if(coolingDownF == true)
        {
            fiona.fillAmount -= 1.0f / waitTime * Time.deltaTime;
        }
        if(fiona.fillAmount >= 0.95f)
        {
            coolingDownF = false;
            
            fionapai.SetActive(false);
        }
        if(shrekpai.activeInHierarchy || fionapai.activeInHierarchy)
        {
            //GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterBhvr>().enabled = false;
            player.GetComponent<CharacterBhvr>().enabled = false;
        }
        else
            player.GetComponent<CharacterBhvr>().enabled = true;
    }
}
