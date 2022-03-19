namespace modul4_1302204075
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<Double> sdb = new SimpleDataBase<Double>();

            sdb.AddNewData(13); sdb.AddNewData(02); sdb.AddNewData(20);
            sdb.PrintAllData();
        }
    }
}