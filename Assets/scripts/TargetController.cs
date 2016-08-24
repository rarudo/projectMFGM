﻿using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour {
    public string prefabFolder_ = "Prefabs";
    public string prefabName_ = "TargetBase";
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            makeTarget();
        }
	}

	public GameObject makeTarget(){
        string prefabName = prefabFolder_ + "/" + prefabName_;
        GameObject target = Instantiate(Resources.Load(prefabName)) as GameObject;
		return target;
	}
}
