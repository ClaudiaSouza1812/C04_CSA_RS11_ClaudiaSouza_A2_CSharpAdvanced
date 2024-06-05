using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_OOP_Interfaces
{
    // Herda propriedades e métodos da classe Course e da interface ICourseSoftSkills

    internal class CourseSoftSkills : Course, ICourseSoftSkills
    {
        // má escolha: colocar a enum dentro da classe, faça uma classe dedicada
        #region Properties

        // implanta as propriedades que pertencem unicamente a ICourseSoftSkills

        public EnumLanguage Language { get; set; }

        public double Price { get; set; }

        #endregion

        #region Constructors

        internal CourseSoftSkills() : base()
        {
            Language = EnumLanguage.English;
            Price = 120.00;
        }

        // Declarar todas as propriedades herdadas e adicionar as novas propriedades declaradas que são obrigatórias no construtor

        internal CourseSoftSkills(int courseId, int areaId, string name, string areaName, string subareaName, string description, EnumLanguage language) : base(courseId, areaId, name, areaName, subareaName, description)
        {
            Language = language;
            Price = 100.00;
        }

        #endregion

        #region Methods

        public override void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Language: ");

            string language = Console.ReadLine();

            if (Enum.TryParse(language, true, out EnumLanguage lang))
            {
                Language = lang;
            }
            else
            {
                Utility.WriteMessage($"Invalid language entered. The default language will be set: {EnumLanguage.English}", "\n\n");
            }

        }

        // Override
        
        public override void Billing(string status)
        {
            Utility.WriteMessage($"Preço ({Price:C2}) - Estado de pagamento: {status} - Language {Language}", "", "\n\n");
        }


        #endregion
    }
}
