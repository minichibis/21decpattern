/** Sam Carpenter
*   Week 4
*   FoodConcrete.cs
*   concrete food for decoration
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConcrete : FoodBase
{
	int hunger = 25;
	int keeptime = 5;
	
    public FoodConcrete(){
		
	}
	
	public override int GetHunger(){
		return hunger;
	}
	
	public override int GetKeepTime(){
		return keeptime;
	}
	
	public override double GetLayer(){
		return 1;
	}
}
