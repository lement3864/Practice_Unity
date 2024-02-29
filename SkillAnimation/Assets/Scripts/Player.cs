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
        print(string.Format("적에게 스킬 {0} 으로 {1}의 피해를 주었습니다.", skill.name, skill.damage));
    }
}
