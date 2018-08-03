using aulaDotNetCore.Areas.Aluno.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace aulaDotNetCore.Areas.Aluno.Models
{
    public class AlunoBLL : IAlunoBLL
    {
        public List<Aluno> GetAlunos()
        {
            var configuration = ConfigurationHelper.GetConfiguration(Directory.GetCurrentDirectory());
            var conexaoString = configuration.GetConnectionString("DefaultConnection");
            List<Aluno> alunos = new List<Aluno>();
            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    SqlCommand cmd = new SqlCommand("GetAlunos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader red = cmd.ExecuteReader();
                    while (red.Read())
                    {
                        Aluno aluno = new Aluno();
                        aluno.Id = Convert.ToInt32(red["Id"]);
                        aluno.Nome = red["Nome"].ToString();
                        aluno.Nascimento = Convert.ToDateTime(red["Nascimento"]);
                        alunos.Add(aluno);
                    }
                }
                return alunos;
            }

            catch
            {
                return null;
            }

        }

       
    }
}
