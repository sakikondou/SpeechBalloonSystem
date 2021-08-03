using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpeak : MonoBehaviour
{
    [SerializeField] InputController m_inputController;
    PlayerInputAction m_inputActions;
    [SerializeField]CommentPanel m_commentPanel;
    [SerializeField] string[] m_coments;
    bool m_inPlayer = false;

    void Speak()
    {
        if (m_inPlayer)
        {
            m_commentPanel.Coments = m_coments;
            m_commentPanel.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (m_inputActions == null)
            {
                m_inputActions = m_inputController.InputActions;
                m_inputActions.Player.Speak.performed += context => Speak();
            }

            m_inPlayer = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_inPlayer = false;
        }
    }
}
