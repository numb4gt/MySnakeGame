using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Threading;
public class SnakeMovment : MonoBehaviour 
{

	public float Speed;
	public float RotationSpeed;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;

	public GameObject TailPrefab;
	public GameObject TailPrefab2;
	public Text ScoreText;
	public int score = 0;
	void Start () {
	tailObjects.Add(gameObject);
	}
	void Update () 
	{
	ScoreText.text = score.ToString();
		transform.Translate(Vector3.forward*Speed*Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up*RotationSpeed*Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.up*-1*RotationSpeed*Time.deltaTime);
		}
	}

	public void AddTail()
	{
		score++;
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}

	public void AddMegaTail()
	{
		score += 3;
		Vector3 newTailPos1 = tailObjects[tailObjects.Count - 1].transform.position;
		newTailPos1.z -= z_offset;
		tailObjects.Add(GameObject.Instantiate(TailPrefab2, newTailPos1, Quaternion.identity) as GameObject);
		
	}
}


