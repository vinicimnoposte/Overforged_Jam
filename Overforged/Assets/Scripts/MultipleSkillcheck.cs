using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleSkillcheck : MonoBehaviour
{
    public Text keyToPress;
    KeyCode key;
    KeyCode[] availableOptions = { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow };
    public Slider quickTimeSlider;
    public float decreaseSpeed;
    public bool freezeTimer = false;
    public GameObject player;
    public GameObject KeytoPressPai;
    public GameObject[] arrayImagens;
    public Vector3 scale;
    public bool startouMinigame = false;
    
    // Start is called before the first frame update
    void Start()
    {
       // int rand = Random.Range(0, 4);
       // key = availableOptions[rand];
       // keyToPress.text = availableOptions[rand].ToString();
       //
       //
       // scale = new Vector3(1, 1, 1);
       //
       // GameObject go = Instantiate(arrayImagens[rand], new Vector3(0, 0, 90.6f), Quaternion.identity) as GameObject;
       // go.transform.parent = GameObject.Find("Canvas").transform;
       // go.transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        if(!freezeTimer)
            quickTimeSlider.value = Mathf.MoveTowards(quickTimeSlider.value, 0, decreaseSpeed * Time.deltaTime);
        if(startouMinigame)
        {
            int rand = Random.Range(0, 4);
            key = availableOptions[rand];
            keyToPress.text = availableOptions[rand].ToString();


            scale = new Vector3(1, 1, 1);

            GameObject go = Instantiate(arrayImagens[rand], new Vector3(0, 0, 90.6f), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Canvas").transform;
            go.transform.localScale = scale;
            startouMinigame = false;
        }
        if(Input.GetKeyDown(key) && quickTimeSlider.value > 0)
        {
            int rand = Random.Range(0,4);
            key = availableOptions[rand];
            keyToPress.text = availableOptions[rand].ToString();
            scale = new Vector3(1, 1, 1);

            GameObject go = Instantiate(arrayImagens[rand], new Vector3(0, 0, 90.6f), Quaternion.identity) as GameObject;
            go.transform.parent = GameObject.Find("Canvas").transform;
            go.transform.localScale = scale;
            if (Input.GetKeyDown(key) && quickTimeSlider.value > 0)
            {
                //freezeTimer = true;
                quickTimeSlider.value += 1;
                //keyToPress.text = "Parabens";
                print("parabens");
                gameObject.SetActive(false);
                player.GetComponent<CharacterBhvr>().minigamefinished = true;
                
                
            }
        }
        if(KeytoPressPai.activeInHierarchy)
        {
            player.GetComponent<CharacterBhvr>().enabled = false;
            
        }
        else
            player.GetComponent<CharacterBhvr>().enabled = true;
        
    }
}
