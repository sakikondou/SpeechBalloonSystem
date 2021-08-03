using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentPanel : MonoBehaviour
{
    public string[] Coments;
    int m_comentIndex;
    [SerializeField] Text m_text;

    private void OnEnable()
    {
        m_comentIndex = 0;
        m_text.text = Coments[m_comentIndex];
        m_comentIndex++;
    }

    public void OnClick()
    {
        if (Coments.Length > 0 &&
            m_comentIndex < Coments.Length)
        {
            m_text.text = Coments[m_comentIndex];
            m_comentIndex++;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
