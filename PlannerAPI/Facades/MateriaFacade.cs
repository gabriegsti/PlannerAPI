using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlannerAPI.Data;
using PlannerAPI.Data.Dtos.Materia;
using PlannerAPI.Facades.Interfaces;
using PlannerAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace PlannerAPI.Facades
{
    public class MateriaFacade : IMateriaFacade
    {
        public PlannerContext Context { get; set; }

        public IMapper Mapper { get; set; }

        public MateriaFacade(PlannerContext context, IMapper mapper)
        {
            Context = context;  
            Mapper = mapper;
        }
        public Materia AdicionaMateria(CreateMateriaDto materiaDto)
        {
            Materia materia = Mapper.Map<Materia>(materiaDto);
            Context.tb_materia.Add(materia);
            Context.SaveChanges();

            return materia;
        }

        public DbSet<Materia> RecuperaMaterias()
        {
            return Context.tb_materia;
        }
        public ReadMateriaDto RecuperaMateriaPorId(int id)
        {
            Materia materia = Context.tb_materia.FirstOrDefault(materia => materia.Id_Materia == id);
            if (materia != null)
            {
                ReadMateriaDto materiaDto = Mapper.Map<ReadMateriaDto>(materia);
                return materiaDto;
            }
            return null;
        }

        public Materia AtualizaMateria(int id, UpdateMateriaDto materiaDto)
        {
            Materia materia = Context.tb_materia.FirstOrDefault(materia => materia.Id_Materia == id);

            if (materia == null)
                return null;

            Mapper.Map(materiaDto, materia);

            Context.SaveChanges();
            return materia;
        }

        public Materia DeletaMateria(int id)
        {
            Materia materia = Context.tb_materia.FirstOrDefault(materia => materia.Id_Materia == id);
            if (materia == null)
                return null;

            Context.Remove(materia);
            Context.SaveChanges();
            return materia;
        }
        public List<Materia> RecuperaMateriaPorTexto(string texto)
        {
            return Context.tb_materia.Where(materia => materia.Professor.ToLower().Contains(texto.ToLower()) || materia.Titulo.ToLower().Contains(texto.ToLower())).ToList<Materia>();
        }
    }
}
