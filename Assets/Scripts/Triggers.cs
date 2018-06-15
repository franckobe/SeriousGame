using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Triggers : MonoBehaviour
{

	public GameObject m_Panel;
	private Text m_question;
	private Text m_reponse_a;
	private Text m_reponse_b;
	private Text m_reponse_c;
	private Text m_reponse_d;
	private QuestionList _questionList;

	// Use this for initialization
	void Start ()
	{
		m_question = GameObject.Find("question").GetComponent<Text>();
		m_reponse_a = GameObject.Find("reponse_A").GetComponentInChildren<Text>();
		m_reponse_b = GameObject.Find("reponse_B").GetComponentInChildren<Text>();
		m_reponse_c = GameObject.Find("reponse_C").GetComponentInChildren<Text>();
		m_reponse_d = GameObject.Find("reponse_D").GetComponentInChildren<Text>();
		m_Panel.SetActive(false);
		_questionList = GameInit.GetQuestionList();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		var name = other.name;
		int nb = int.Parse(name.Split("_".ToCharArray())[1]);
		if (name.StartsWith("trigger"))
		{
			if (nb < _questionList.questions.Count)
			{
				FillQuestion(_questionList.questions[nb]);
				m_Panel.SetActive(true);
				GetComponent<ThirdPersonUserControl>().canMove = false;
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		other.isTrigger = false;
		m_Panel.SetActive(false);
	}

	private void FillQuestion(Question question)
	{
		m_question.text = question.label;
		m_reponse_a.text = question.responses[0].label;
		m_reponse_b.text = question.responses[1].label;
		m_reponse_c.text = question.responses[2].label;
		m_reponse_d.text = question.responses[3].label;
	}
	
}
