using inheritance.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>(); //AQUI A LISTA ESTÁ COMPLETAMENTE DECLARADA E INSTANCIADA.

        for (int i = 1 ; i <= n; i++)
        {
            Console.WriteLine($"Employee #{i} data: ");
            Console.Write("Outsourced (y/n)? ");
            char yN = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (yN == 'y' || yN == 'Y')
            {
                Console.Write("Additional charge: ");
                double adittional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new OutSourceEmployee(name, hours, value, adittional)); //LISTAS NÃO FICAM PRESAS DENTRO DE IFS E ELSES
                                                                                      //A NÃO SER QUE SEJAM INSTANCIADAS DENTRO
                                                                                      //(DECLARADA E INSTANCIADA NA LINHA 10) 
            }
            else
            {
                employees.Add(new Employee(name, hours, value)); // ISSO NÃO É UMA LISTA INSTANCIADA DENTRO DA OUTRA, É UM CONSTRUTOR
                                                                 // SENDO INSTANCIADO DENTRO DA LISTA! (VER ANOTAÇÃO LINHA 10)
                
            }           

        }

        Console.WriteLine("PAYMENTS: ");

        foreach (Employee list in employees)
        {
            Console.Write(list.Name + " - $");
            Console.Write(list.Payment().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }

    }
}