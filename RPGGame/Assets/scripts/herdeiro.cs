using UnityEngine;

[System.Serializable]
public class Mago : Personagem
{
    public int mana;

    public int GetMana() => mana;
    public void SetMana(int novaMana) => mana = novaMana;
}