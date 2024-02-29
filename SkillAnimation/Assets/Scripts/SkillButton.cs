using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    // ScriptableObject
    public SOSkill skill;

    // Player 객체 연결
    public Player player;

    // 스킬 이미지
    public Image imgIcon;

    // Cooldown 이미지
    public Image imgCool;

    void Start()
    {
        // SO Skill에 등록한 스킬 아이콘 연결
        imgIcon.sprite = skill.icon;

        // Cool 이미지 초기 설정
        imgCool.fillAmount = 0;
    }

    public void OnClicked()
    {
        // Cool 이미지의 fillAmount가 0보다 크면
        // 아직 쿨타임이 끝나지 않았음!
        if (imgCool.fillAmount > 0) return;

        // Player 객체의 ActivateSkill 호출
        player.ActivateSkill(skill);

        // 스킬 Cool 처리
        StartCoroutine(SC_Cool());
    }

    IEnumerator SC_Cool()
    {
        // skill.cool 값에 따라 달라짐
        float tick = 1f / skill.cool;
        float t = 0;

        imgCool.fillAmount = 1;

        // 10초에 걸쳐 1 -> 0으로 값을 변경
        while (imgCool.fillAmount > 0)
        {
            imgCool.fillAmount = Mathf.Lerp(1, 0, t);
            t += (Time.deltaTime * tick);

            yield return null;
        }
    }
}
