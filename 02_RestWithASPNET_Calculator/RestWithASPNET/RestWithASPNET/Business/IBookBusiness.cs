﻿using RestWithASPNET.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        void Delete(long id);

        BookVO FindByID(long id);

        List<BookVO> FindAll();
    }
}
