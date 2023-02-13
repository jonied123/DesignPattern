namespace TutorialsTeacher
{
    public class Program
    {

        public interface ICostomerDataAccess
        {
            public string GetCostomerName(int i);
        }

        public class CostomerDataAccess : ICostomerDataAccess
        {
            public CostomerDataAccess()
            {
            }

            public string GetCostomerName(int i)
            {
                return $"{"Dummywert für",-25}" + i;
            }
        }

        public class DataAcessFactory
        {
            public CostomerDataAccess getCostomerDataAccess()
            {
                return new CostomerDataAccess();
            }
        }

        public class BusinessLogicClass
        {
            public ICostomerDataAccess costomerData;
            public BusinessLogicClass()
            {
                costomerData = new DataAcessFactory().getCostomerDataAccess();
            }
            public string GetData(int i)
            {
                return costomerData.GetCostomerName(i);
            }
        }
    }
}