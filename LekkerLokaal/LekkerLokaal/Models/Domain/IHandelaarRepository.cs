﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LekkerLokaal.Models.Domain
{
    public interface IHandelaarRepository
    {
        IEnumerable<Handelaar> GetAll();

        IEnumerable<Handelaar> GetHandelaarsNogNietGoedgekeurd(IEnumerable<Handelaar> inputlijst);

        IEnumerable<Handelaar> GetHandelaarsGoedgekeurd(IEnumerable<Handelaar> inputlijst);

        void Add(Handelaar handelaar);

        void Remove(int handelaarId);

        void SaveChanges();

        int getAantalHandelaarsverzoeken();

        Handelaar GetByHandelaarId(int handelaarId);

        Handelaar GetByEmail(string email);

        Handelaar GetByHandelaarIdNotAccepted(int handelaarId);
    }
}
