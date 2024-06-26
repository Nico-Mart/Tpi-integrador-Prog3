﻿using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AlbunRepository : Repository, IAlbunRepository
    {
        public AlbunRepository(AlbunsContext context) : base(context)
        { 
        }
        public void AddAlbun(Albun albun)
        {
            _context.Add(albun);
        }

        public void DeleteAlbun(Albun albun)
        {
            _context.Remove(albun);
        }

        public IEnumerable<Albun> GetAllAlbun()
        {
            return _context.Albuns.ToList();
        }

        public Albun? GetAlbunById(int albunId)
        {
            return _context.Albuns.Find(albunId);
        }

        public void UpdateAlbun(Albun albun)
        {
            _context.Albuns.Update(albun);
        }
    }
}
