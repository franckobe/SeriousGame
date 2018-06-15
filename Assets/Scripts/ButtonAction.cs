using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class ButtonAction : MonoBehaviour
{
	private Button m_button;
	public int index;
	public GameObject player;
	public GameObject panel;
	
	// Use this for initialization
	void Start ()
	{
		m_button = GetComponent<Button>();
		m_button.onClick.AddListener(OnClickListener);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnClickListener()
	{
		panel.SetActive(false);
		player.GetComponent<ThirdPersonUserControl>().canMove = true;
	}
}
