using Dual_Hotel_EX3.Model;
using Dual_Hotel_EX3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Controller
{
    public class TemporadesController : CommonController
    {

        Temporades t = new Temporades();
        List<Temporada> temporades;

        public TemporadesController() {

            fillTemporades();
            t.Show();

        }

        public void fillTemporades() {

            try
            {
                t.temporadesGrid.ColumnCount = 7;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            t.temporadesGrid.Columns[0].Name = "Temporada";
            t.temporadesGrid.Columns[0].DataPropertyName = "Nom";
            t.temporadesGrid.Columns[0].Width = 100;

            t.temporadesGrid.Columns[1].Name = "Dia d'inici de temporada";
            t.temporadesGrid.Columns[1].DataPropertyName = "DataIniciDay";
            t.temporadesGrid.Columns[2].Name = "Mes d'inici de temporada";
            t.temporadesGrid.Columns[2].DataPropertyName = "DataIniciMonth";

            t.temporadesGrid.Columns[3].Name = "Dia de final de temporada";
            t.temporadesGrid.Columns[3].DataPropertyName = "DataFinalDay";
            t.temporadesGrid.Columns[4].Name = "Mes de final de temporada";
            t.temporadesGrid.Columns[4].DataPropertyName = "DataFinalMonth";

            t.temporadesGrid.Columns[5].Name = "Multiplicador";
            t.temporadesGrid.Columns[5].DataPropertyName = "Multiplicador";

            t.temporadesGrid.Columns[6].Name = "IDTemporada";
            t.temporadesGrid.Columns[6].DataPropertyName = "IDTemporada";
            t.temporadesGrid.Columns[6].Visible = false;

            t.temporadesGrid.AutoGenerateColumns = false;

            temporades = TemporadaRepository.GetTemporadas();
            t.temporadesGrid.DataSource = temporades;

        }


    }
}
