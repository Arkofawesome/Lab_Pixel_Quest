using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HW3PlayerDialogue : MonoBehaviour
{
    public List<string> dialogue = new List<string>();
    private bool canSpeak = false;
    private bool isSpeaking = false;
    private GameObject _talkPanel;
    private TextMeshProUGUI _talkText;
    private int _talkIndex = 0;
    private bool isEvilWizard = false;
    public string nextLevel = "Graveyard";

    private void Start()
    {
        isEvilWizard = false;

        _talkText = GameObject.Find(HW3Structs.GameObjects.talkText).GetComponent<TextMeshProUGUI>();

        _talkPanel = GameObject.Find(HW3Structs.GameObjects.talkPanel);
        _talkPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpeaking && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogue.Count - 1 == _talkIndex)
            {
                isSpeaking = false;
                _talkPanel.SetActive(false);
                if (isEvilWizard)
                {
                    SceneManager.LoadScene(nextLevel);
                }
            }
            else
            {
                _talkIndex++;
                _talkText.text = dialogue[_talkIndex];
            }
        }
        else if (canSpeak && Input.GetKeyDown(KeyCode.E))
        {
            isEvilWizard = dialogue[0].Equals("Finally I have found you");  
            isSpeaking = true;
            _talkPanel.SetActive(true);
            _talkIndex = 0;
            _talkText.text = dialogue[_talkIndex]; 
        }
    }

    public void SetCanSpeak(bool newCanSpeak)
    {
        canSpeak = newCanSpeak;
    }

    public bool IsSpeaking()
    {
        return isSpeaking;
    }

    public void CopyDialogue(List<string> newDialogue)
    {
        dialogue.Clear();
        dialogue.AddRange(newDialogue);
    }
}
