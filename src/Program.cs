using System;

namespace Databaseoppgave8_31_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlClient sqlClient = new SqlClient("localhost", "winDB", "8asd80da0das089sad098dsa98ads", "elever");
            sqlClient.Query("SELECT * WHERE ");
        }
    }
}
