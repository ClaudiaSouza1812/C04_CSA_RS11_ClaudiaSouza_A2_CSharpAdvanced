using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace D06_OOP_Interfaces
{
    // Herda propriedades e métodos da interface ICourseIT e da classe Course
    // Herdar da classe Course é o mesmo que herdar da interface ICourse

    internal class CourseIT : Course, ICourseIT
    {
        // implanta as propriedades que pertencem unicamente a ICourseIT

        #region Properties

        public bool Exam { get; set; }
        public double Price { get; set; }

        // reescrever a propriedade herdada: override
        // ofuscar, criar uma nova com o mesmo nome: new 
        public override string FullCourse => $"Course nº {CourseId}: {Name} - {AreaName} - {SubareaName} - {Description}, Exam? {Exam}"; // Get

        #endregion

        #region Constructors

        public CourseIT() : base()
        {
            Exam = true;
            Price = 100.00;
        }

        // Declarar todas as propriedades herdadas e adicionar as novas propriedades declaradas que são obrigatórias no construtor

        public CourseIT(int courseId, int areaId, string name, string areaName, string subareaName, string description, bool exam) : base(courseId, areaId, name,  areaName, subareaName, description)
        {
            Exam = exam;
            Price = 100.00; ;
        }

        #endregion

        #region Methods

        // reescrever o método herdado: override
        // ofuscar, criar um novo método com o mesmo nome: new 

        public override void ReadCourse()
        {
            base.ReadCourse();

            Utility.WriteMessage("Course exam (true|false)? ");

            Exam = Convert.ToBoolean(Console.ReadLine());
        }

        public override void Billing(string status)
        {
            Utility.WriteMessage($"Preço ({Price:C2}) - Estado de pagamento: {status}", "", "\n\n");
        }


        #endregion

    }
}
