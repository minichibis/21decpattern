/** Sam Carpenter
*   Week 4
*   SeasoningBase.cs
*   increased hunger gain
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honey : SeasoningBase
{
	public Honey(FoodBase f){
		seasoned = f;
	}
	
    public override int GetHunger(){
		return seasoned.GetHunger() + (int)(25.0 * (1.0 / seasoned.GetLayer()));
	}
}
