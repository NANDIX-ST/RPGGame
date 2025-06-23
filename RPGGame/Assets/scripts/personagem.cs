using UnityEngine;

public class Personagem
{
    // 1.1 - Quatro variáveis com getters e setters
    private string nome;
    private int nivel;
    private int vida;
    private int mana;

    public string GetNome() => nome;
    public void SetNome(string value) => nome = value;

    public int GetNivel() => nivel;
    public void SetNivel(int value) => nivel = value;

    public int GetVida() => vida;
    public void SetVida(int value) => vida = value;

    public int GetMana() => mana;
    public void SetMana(int value) => mana = value;

    // 2 - Função de comparação entre dois personagens
    public string CompararForca(Personagem outro)
    {
        if (this.nivel > outro.nivel)
            return $"{nome} é mais forte que {outro.GetNome()}";
        else if (this.nivel < outro.nivel)
            return $"{nome} é mais fraco que {outro.GetNome()}";
        else
            return $"{nome} e {outro.GetNome()} têm o mesmo nível de força";
    }
}
