using UnityEngine;

public class TesteRPG : MonoBehaviour
{
    public Personagem personagem1;
    public Mago mago1;

    void Start()
    {
        // Inicializando personagem1
        personagem1 = new Personagem();
        personagem1.SetNome("Guerreiro");
        personagem1.SetNivel(10);
        personagem1.SetVida(100);
        personagem1.SetAtaque(20);

        // Inicializando mago1
        mago1 = new Mago();
        mago1.SetNome("Merlin");
        mago1.SetNivel(12);
        mago1.SetVida(80);
        mago1.SetAtaque(25);
        mago1.SetMana(100);

        // Exibindo valores com Debug.Log
        Debug.Log("Personagem: " + personagem1.GetNome() + ", Nível: " + personagem1.GetNivel());
        Debug.Log("Mago: " + mago1.GetNome() + ", Nível: " + mago1.GetNivel() + ", Mana: " + mago1.GetMana());

        // Comparação de níveis
        bool magoMaisForte = mago1.CompararNivel(personagem1);
        Debug.Log("Mago tem nível maior que Guerreiro? " + magoMaisForte);
    }
}