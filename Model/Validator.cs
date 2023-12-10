using Microsoft.EntityFrameworkCore;


namespace Multiprocessor_And_Multithreaded_Programming
{
    public interface IValidator
    {
        string TrainAddPreValidation(string trainsName, string trainsDOC);
        string WayIsValidation(object whereWay);
        string WayValidation(object whereWay);



    }
    public class Validator : IValidator
    {
        public string WayValidation(object whereWay)
        {
            string errors = "";
            if (whereWay == null) { errors += "Некорректный ввод конца назначения"; return errors; }
            if (whereWay.ToString() == "") { errors += "Некорректный ввод конца назначения"; return errors; }
            return errors;

        }

        public string WayIsValidation(object whereWay)
        {
            string errors = "";
            if (whereWay == null) { errors += "Некорректный ввод"; return errors; }
            if (DbManagement.CheckWayExist (whereWay.ToString()!)) { errors += "Такой пункт назначения уже существует"; } // почему он его не видит?
            return errors;
        }

        public string TrainAddPreValidation(string trainsName, string trainsDOC)
        {
            string errors = "";
            if (trainsName == "") { errors += "Название введено некорректно" + Environment.NewLine; } //управление содержимым стека
            if (trainsDOC == "") { errors += "Дни курсирования введены некорректно" + Environment.NewLine; }
            
            for (int i = 0; i < trainsName.Length - 1; i++)
            {
                if (!char.IsLetter(trainsName[i])) // смотрим, относится ли символ к содержимому Юникода
                {
                    errors += "Название введено некорректно" + Environment.NewLine;
                    break;
                }
            }
            
            return errors;
        }
    }
}