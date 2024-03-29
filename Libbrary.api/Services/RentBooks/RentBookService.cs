﻿using Libbrary.api.Dto.BookDtos;
using Libbrary.api.Dto.RentBookDtos;

namespace Libbrary.api.Services.RentBooks
{
    public interface RentBookService
    {
        public void Add(AddRentBookDto dto);
        public List<GetRentBookDto> Get();
        public void GetBack(int id);
    }
}
