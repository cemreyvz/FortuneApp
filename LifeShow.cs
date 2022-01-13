using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeShow : MonoBehaviour
{
    public GameObject Life;
    public int Lifevalue;
    public string text;
    public Button niyetcek;
    // Start is called before the first frame update
    void Start()
    {
        Lifevalue = 1;

        Life.GetComponent<Text>().text = "Life : " + Lifevalue;
    }

    // Update is called once per frame
    void Update()
    {
        Button btn = niyetcek.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        void TaskOnClick()
        {

            Life.GetComponent<Text>().text = "Life : " + (Lifevalue - 1);
        }

        
    }
}
