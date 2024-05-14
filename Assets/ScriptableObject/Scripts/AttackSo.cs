﻿using UnityEngine;
[CreateAssetMenu(fileName = "DefaultAttackS0",menuName = "TopDownController/Attacks/Default",order =0)]
public class AttackSO: ScriptableObject
{
    [Header("Attack info")]
    public float size;
    public float delay;
    public float power;
    public float speed;
    public LayerMask target;

    [Header("Knock Back Info")]
    public bool isOnKnockBack;
    public float kncokbackPower;
    public float knockbackTime;
}
