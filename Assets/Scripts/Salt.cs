/** Sam Carpenter
*   Week 4
*   Salt.cs
*   increased keep time
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salt : SeasoningBase
{
	public Salt(FoodBase f){
		seasoned = f;
	}
	
	public override int GetKeepTime(){
		return seasoned.GetKeepTime() + (int)(5.0 * (1.0 / seasoned.GetLayer()));
	}
}
