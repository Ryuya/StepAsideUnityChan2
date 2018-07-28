using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
	public GameObject unityChan;
	public List<GameObject> prefabs = new List<GameObject> ();
	private float offset_z = 12.0f;

	//public GameObject[] coins, cars, cones;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		//Listの要素数だけfor文を回す
		for (int i = 0; i < prefabs.Count; i++) {
			//Listの要素がNullだった場合Listの要素そのものを消す
			if (prefabs [i] == null) {
				//Listの要素そのものを消す
				prefabs.RemoveAt (i);
				//forループを抜ける
				break;
			}
			if (unityChan.transform.position.z - offset_z > prefabs [i].transform.position.z) {
				Destroy (prefabs [i]);
			}

		}
	}

	public void GetPrefabs ()
	{
//		coins = GameObject.FindGameObjectsWithTag ("CoinTag");
//		cars = GameObject.FindGameObjectsWithTag ("CarTag");
//		cones = GameObject.FindGameObjectsWithTag ("TrafficConeTag");
	}

}
