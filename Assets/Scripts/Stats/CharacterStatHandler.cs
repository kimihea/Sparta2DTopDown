using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;
    public CharacterStat CurrentStat { get; private set; }
    public List<CharacterStat> statModifiers = new List<CharacterStat>();

    private void Awake()
    {
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {

        AttackSO attackSO = null;
        if(baseStat.attackSO != null)
        {
            attackSO = Instantiate(baseStat.attackSO);
        }
        CurrentStat = new CharacterStat { attackSO = attackSO };
        //TODO : 지금은 기본 능력치만 적용 앞으로는 능력치 강화기능이 적용된다.
        CurrentStat.statsChangeType = baseStat.statsChangeType;
        CurrentStat.MaxHealth = baseStat.MaxHealth;
        CurrentStat.speed = baseStat.speed;
    }
}