using BecareAPI.Models;
using BecareAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BecareAPI.Repository.Implementation
{
    public class HospitalRepository : IHospital
    {
        public ICollection<Hospital> ListaHospitais()
        {
            try
            {
                Random rnd = new Random();

                var lista = new List<Hospital>();



                lista.Add(new Hospital(rnd.Next(),"HM Infantil Menino Jesus", "R. dos Ingleses, 258 - Bela Vista", "01329-000", "3253-5200", true, true, -23.559825,-46.647081));

                lista.Add(new Hospital(rnd.Next(), "Hospital do Servidor Público Municipal - HSPM", "R. Castro Alves, 60 - Aclimação", "01532-900", "3208-2211", true, true, -23.567279, -46.639134));

                lista.Add(new Hospital(rnd.Next(), "PSM Barra Funda - Álvaro Dino de Almeida", "R. Vitorino Carmilo, 717 - Barra Funda", "01153-000", "3826-5666", true, true, -23.530828, -46.652939));

                lista.Add(new Hospital(rnd.Next(), "HM Cidade Tiradentes – Carmem Prudente", "Av. dos Metalúrgicos, 2100 – Cidade Tiradentes", "01329-000", "2559-6200", true, true, -23.599656, -46.401945));

                lista.Add(new Hospital(rnd.Next(), "HM Prof. Dr. Alípio Correa Netto - Ermelino Matarazzo", "Al. Rodrigo de Brum, 1989 - V. Paranaguá", "03807-230", "2943-9944", true, true, -23.500394, -46.472467));

                lista.Add(new Hospital(rnd.Next(), "HM Prof. Dr. Waldomiro de Paula - Itaquera/Planalto", "R. Augusto Carlos Baumann, 1074 - Itaquera", "08210-590", "2944-6355", true, true, -23.530978, -46.444534));

                lista.Add(new Hospital(rnd.Next(), "PSM Julio Tupy", "R. Serra da Queimada, 800 - Pq. Guaianases", "08431-640", " 2035-1821 / 2035-1823", true, true, -23.527542, -46.411109));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. Ignácio Proença de Gouvêa", "R. Juventus, 562 - Mooca", "03124-020", "2069-9923 / 2068-6700", true, true, -23.571635, -46.590161));

                lista.Add(new Hospital(rnd.Next(), "HM Tide Setubal - São Miguel", "R. Dr. José Guilherme Eiras, 123 - São Miguel Paulista", "08010-220", "2297-0022", true, true, -23.587953, -46.514194));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. Benedito Montenegro - Jardim Iva", "R. Antonio Lázaro, 226 - Jd. Iva", " 03921-080", "2721-8684", true, true, -23.559825, -46.647081));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. Carmino Caricchio - Tatuapé", "Av. Celso Garcia, 4815 - Tatuapé", "03063-000", " 2091-7000", true, true, -23.532423, -46.566560));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. Alexandre Zaio - Vila Nhocuné ", "R. Alves Maldonado, 128 - Jd. São João", "03558050", "2749-2855", true, true, -23.542904, -46.502150));

                lista.Add(new Hospital(rnd.Next(), "HM e Matern. Dr. Mário de M. A. da Silva - Cachoeirinha", "Av. Deputado Emílio Carlos, 3100 - V. N. Cachoeirinha", "02720-200", "3859-4122 / 3859-4022", true, true, -23.479903, -46.671517));

                lista.Add(new Hospital(rnd.Next(), "PSM Freguesia do Ó - 21 de Junho", "R. dos Ingleses, 258 - Bela Vista", "01329-000", "3253-5200", true, true, -23.489934, -46.688783));

                lista.Add(new Hospital(rnd.Next(), "PSM Perus", "R. Júlio de Oliveira, 80 - V. Flamengo", "02738-000", "3975-5866", true, true, -23.403593, -46.738484));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. José Soares Hungria - Pirituba", "Av. Menotti Laudísio, 100 - Jardim Cidade Pirituba", "02945-000", "3974-7000", true, true, -23.484607, -46.727609));

                lista.Add(new Hospital(rnd.Next(), "PSM Santana - Lauro Ribas Braga", "R. Voluntários da Pátria, 943 - Santana", "02011-000", "2223-2900 / 2221-3682", true, true, -23.511738, -46.626598));

                lista.Add(new Hospital(rnd.Next(), "HM Vereador José Storopolli - Vila Maria", "R. Francisco Fanganielo, 127 - Pq. Novo Mundo", "02181-160", "2967-0103", true, true, -23.521913, -46.561686));

                lista.Add(new Hospital(rnd.Next(), "PSM Vila Maria Baixa", "Pça. Engenheiro Hugo Brandi, 15 - Pq. Novo Mundo", "02168-050", "2633-9530", true, true, -23.517285, -46.577491));

                lista.Add(new Hospital(rnd.Next(), "PSM Bandeirantes - Dr Caetano Virgílio Netto", "R. Augusto Farinha, 1125 - Jd. Pinheiros",
                    "05594-001", "3731-6018 / 3735-1190", true, true, -23.584307, -46.738988));

                lista.Add(new Hospital(rnd.Next(), "HM Prof. Mario Degni - Jardim Sarah", "R. Lucas de Leyde, 257 - V. Antonio", "05376-010", "3768-4900", true, true, -23.577897, -46.765401));

                lista.Add(new Hospital(rnd.Next(), "PSM Lapa - Prof. João Catarin Mezomo", "Av. Queiroz Filho, 313 - Pq. da Lapa", "05319-000", "3022-4122", true, true, -23.537549, -46.722526));

                lista.Add(new Hospital(rnd.Next(), "PSM Dona Maria Antonieta F. de Barros", "R. Antonio Felipe Filho, 180 - Grajaú", "04845-000", "5972-4881 / 5972-9883", true, true, -23.748548, -46.690558));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. Arthur Ribeiro Saboya - Jabaquara", "Av. Francisco de Paula Quintanilha Ribeiro, 860 - Jabaquara", "04330-020", "5013-5302", true, true, -23.653189, -46.645687));

                lista.Add(new Hospital(rnd.Next(), "HM Dr. Fernando Mauro Pires da Rocha - Campo Limpo", "Estr. de Itapecerica, 1661 - Campo Limpo", "05835-005", "5519-5800 / 5512-7650", true, true, -23.648690, -46.748854));

                lista.Add(new Hospital(rnd.Next(), "HM M’Boi Mirim", "Estr. de M’Boi Mirim, 5203 –Jd. Ângela", "04948-970", "5832-2500", true, true, -23.691078, -46.774551));

                lista.Add(new Hospital(rnd.Next(), "PSM Balneário São José", "R. Gaspar Leme X R. Manoel Alves de Souza, S/N - Balneário São José", "04864-050", "5979-7173", true, true, -23.770744, -46.723963));

                lista.Add(new Hospital(rnd.Next(), "PSM Augusto Gomes de Mattos", "R. Júlio Felipe Guedes, 200 - V. das Mercês", "04174-040", "2969-9950", true, true, -23.633267, -46.607653));

                lista.Add(new Hospital(rnd.Next(), "PSM Santo Amaro - José Sylvio de Camargo", "Av. Adolfo Pinheiro, 805 - Santo Amaro", "04733-100", "5523-1777 / 5523-1424", true, true, -23.645724, -46.701554));


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ICollection<Hospital> FiltrarHospital(string nome)
        {
            try
            {
                ICollection<Hospital> hospitais = this.ListaHospitais();

                var result = hospitais.Where(c => c.Nome.ToLower().Contains(nome.ToLower()));

                return result.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
