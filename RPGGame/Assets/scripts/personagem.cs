using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int nivel;
    [SerializeField] private int vida;
    [SerializeField] private int mana;

    // Propriedades para acessar as variáveis privadas
    public string Nome
    {
        get => nome;
        set => nome = value;
    }

    public int Nivel
    {
        get => nivel;
        set => nivel = value;
    }

    public int Vida
    {
        get => vida;
        set => vida = value;
    }

    public int Mana
    {
        get => mana;
        set => mana = value;
    }

    // Função para comparar nível entre personagens
    public string CompararNivel(Personagem outro)
    {
        if (this.nivel > outro.nivel)
            return $"{this.nome} é mais forte que {outro.nome}.";
        else if (this.nivel < outro.nivel)
            return $"{outro.nome} é mais forte que {this.nome}.";
        else
            return $"{this.nome} e {outro.nome} têm o mesmo nível.";
    }
}