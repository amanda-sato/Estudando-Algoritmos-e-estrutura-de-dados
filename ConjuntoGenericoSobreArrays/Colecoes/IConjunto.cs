namespace Colecoes {
    public interface IConjunto<T> {
        bool Existe(T valor);
        bool Inserir(T novoValor);
        T[] ListarTudo();
        bool Remover(T valor);

        //Conjunto<T> Soma(Conjunto<T> conjunto);
        IConjunto<T> Soma(IConjunto<T> conjunto);
    }
}
