namespace D08_CollectionsGeneric_Constraints
{

    internal class ReferenceTypeConstraint<T> where T : class // reference type
    {

        private T value;

        public ReferenceTypeConstraint(T item)
        {

            value = item;

        }

        public T GetItem()
        {

            return value;

        }

    }

    class Teste
    {

    }

}
