using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    public void ActivateSkill(SOSkill skill)
    {
        anim.Play(skill.animationName);
        print(string.Format("������ ��ų {0} ���� {1}�� ���ظ� �־����ϴ�.", skill.name, skill.damage));
    }
}
