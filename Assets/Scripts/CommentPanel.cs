using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentPanel : MonoBehaviour
{
    [SerializeField] string[] m_coments;
    int m_comentIndex;
    [SerializeField] Text m_text;

    private void OnEnable()
    {
        m_comentIndex = 0;
    }

    public void OnClick()
    {
        if (m_coments.Length > 0 &&
            m_comentIndex < m_coments.Length)
        {
            m_text.text = m_coments[m_comentIndex];
            m_comentIndex++;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
