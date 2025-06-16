using UnityEngine;

[System.Serializable]
public class Personagem
{
    public string nome;
    public int nivel;
    public float vida;
    public float ataque;

    // Getters e Setters
    public string GetNome() => nome;
    public void SetNome(string novoNome) => nome = novoNome;

    public int GetNivel() => nivel;
    public void SetNivel(int novoNivel) => nivel = novoNivel;

    public float GetVida() => vida;
    public void SetVida(float novaVida) => vida = novaVida;

    public float GetAtaque() => ataque;
    public void SetAtaque(float novoAtaque) => ataque = novoAtaque;

    // 2. Comparação entre dois personagens
    public bool CompararNivel(Personagem outro)
    {
        return this.nivel > outro.nivel;
    }
}