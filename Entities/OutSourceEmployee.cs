

namespace inheritance.Entities
{
    internal class OutSourceEmployee : Employee
    {
        public double Additional { get; set; }

        public OutSourceEmployee() { }
        public OutSourceEmployee(string name, int hours, double valuePerHour, double additional) : base(name, hours, valuePerHour)
        {
            Additional = additional;
        }

        public sealed override double Payment() //SEALED NÃO PODE SER USADA POR OUTRA SUBCLASSE
                                                //E OVERRIDE POSSO MODIFICAR O MÉTODO DA SUPERCLASSE
        {
            return base.Payment() + (Additional + (Additional * 0.10)); //UMA FORMA MAIS SIMPLES DE DECLARAR SERIA (1.1 * ADDITIONAL)
                                                                        //QUE SERIA OS 110% DO VALOR ADICIONAL
            
        }

        
    }
}
