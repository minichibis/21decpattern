/** Sam Carpenter
*   Week 4
*   SeasoningBase.cs
*   a most basic decorator
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SeasoningBase : FoodBase{
	protected FoodBase seasoned;
	
	public SeasoningBase(FoodBase f){
		seasoned = f;
	}
	
	public SeasoningBase(){}
	
	public override int GetHunger(){
		return seasoned.GetHunger();
	}
	
	public override int GetKeepTime(){
		return seasoned.GetKeepTime();
	}
	
	public override double GetLayer(){
		return seasoned.GetLayer() + 1;
	}
}
