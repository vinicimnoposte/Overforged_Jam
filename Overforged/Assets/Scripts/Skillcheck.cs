using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skillcheck : MonoBehaviour
{
    public Image shrek;
    public float carrega = 0;
    public bool coolingDown;
    public float waitTime = 10.0f;
    public float sobe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coolingDown == true)
        {
            shrek.fillAmount -= 1.0f / waitTime * Time.deltaTime;
        }
       // shrek.fillAmount = carrega;
       // if (shrek.fillAmount > 0)
            

        // carrega += Time.deltaTime;
        // if(carrega == 1)
        // {
        //
        // }
        if (Input.GetKeyDown("space"))
        {
            coolingDown = true;
            shrek.fillAmount += sobe;
        }
        if(shrek.fillAmount == 1)
        {
            coolingDown = false;
            print("Felicidades");
        }
        //if(Input.GetKeyDown(""))
        
    }
}
