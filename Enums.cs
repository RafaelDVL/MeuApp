enum EPrioridade{

    Alta = 0,
    Media = 1,
    Baixa = 2

}


struct Pedido{
    public int Id;
    public string Nome;
    public EPrioridade Prioridade;


    public Pedido(int id, string nome, EPrioridade prioridade){
        Id = id;
        Nome = nome;
        Prioridade = prioridade;
    }
}