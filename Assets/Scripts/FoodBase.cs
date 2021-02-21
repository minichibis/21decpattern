/** Sam Carpenter
*   Week 4
*   FoodBase.cs
*   abstract base for decorators (not abstrat actully, sorry for actually trying to use something unity)
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBase
{
	int hunger = 25;
	int keeptime = 5;
	
    public virtual int GetHunger(){
		return hunger;
	}
	
	public virtual int GetKeepTime(){
		return keeptime;
	}
	
	public virtual double GetLayer(){
		return 1;
	}
}
