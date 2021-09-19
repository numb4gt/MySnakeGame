using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour 
{

	public float XSize = 8.8f;
	public float ZSize = 8.8f;
	public GameObject foodPrefab;
	public GameObject MegafoodPrefab;
	public Vector3 curPos;
	public GameObject curFood;

	public int megas = 0;

	void AddNewMegaFood()
    {
		RandomPos();
		curFood = GameObject.Instantiate(MegafoodPrefab, curPos, Quaternion.identity) as GameObject;

	}
	void AddNewFood()
	{

	RandomPos();
	curFood = GameObject.Instantiate(foodPrefab,curPos,Quaternion.identity) as GameObject;
	}
	void RandomPos()
	{
    curPos = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize));
	}

	void Update()
	{
		if(!curFood)
		{

			if (megas != 4)
			{
				AddNewFood();
				megas++;
            }
            else
            {
				AddNewMegaFood();
				megas = 0;
            }
		}
		else
		{
			return;
		}
	}
}
