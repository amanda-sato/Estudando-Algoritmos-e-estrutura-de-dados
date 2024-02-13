namespace _20231120_Grupo3 {
    public interface IConjunto<T> {
        bool AdicionarAoConjunto(T novo);
        T Encontra(T item);
        bool Existe(T item);
        void Remove(T item);

        void Inverter();

       // void AddNodeAtStart(int data);
        string ToString();
    }
}