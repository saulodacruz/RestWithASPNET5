﻿using RestWithASPNET.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);

        PersonVO Update(PersonVO person);

        void Delete(long id);

        PersonVO FindByID(long id);

        List<PersonVO> FindAll();
    }
}
