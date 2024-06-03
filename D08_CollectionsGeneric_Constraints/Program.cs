using D00_Utility;

namespace D08_CollectionsGeneric_Constraints
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Teste test01 = new Teste();

            var stringTest = new ReferenceTypeConstraint<string>("Olá turma!");

            var teste = new ReferenceTypeConstraint<Teste>(test01);

            Utility.WriteMessage(stringTest.GetItem());

            // Descomentar a linha de baixo dá erro. Porquê?
            // var intTest = new ReferenceTypeConstraint<int>(123);

            Utility.TerminateConsole();

        }

    }

}
