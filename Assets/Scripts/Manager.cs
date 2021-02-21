using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
	public FoodBase f;
	public Text ht;
	public Text kt;
	public Text ft;
	
	string[] foodtext = {"yum!", "delicious!", "positively scrumptious!", "amazing!", "wow!"};
	int i = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        f = new FoodBase();
		ft.text = "feed me!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
			f = new FoodBase();
			ft.text = foodtext[i];
			i++;
			i = i%5;
		}else if (Input.GetKeyDown(KeyCode.Q)){
			f = new Salt(f);
		} else if (Input.GetKeyDown(KeyCode.W)){
			f = new Honey(f);
		}
		ht.text = "hunger gain from food is " + f.GetHunger() + " points.";
		kt.text = "keep time of food is " + f.GetKeepTime() + " days.";
    }
}
