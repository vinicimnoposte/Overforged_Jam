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
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, 4);
        key = availableOptions[rand];
        keyToPress.text = availableOptions[rand].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(!freezeTimer)
            quickTimeSlider.value = Mathf.MoveTowards(quickTimeSlider.value, 0, decreaseSpeed * Time.deltaTime);

        if(Input.GetKeyDown(key) && quickTimeSlider.value > 0)
        {
            int rand = Random.Range(0,4);
            key = availableOptions[rand];
            keyToPress.text = availableOptions[rand].ToString();
            if(Input.GetKeyDown(key) && quickTimeSlider.value > 0)
            {               
                 freezeTimer = true;
                 quickTimeSlider.value += 1;
                 keyToPress.text = "Parabens";
                print("parabens");
                 gameObject.SetActive(false); 
            }
        }
    }
}
