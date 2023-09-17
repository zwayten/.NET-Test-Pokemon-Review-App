﻿namespace Domain.Dto
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<OwnerDto> Owners { get; set; }
    }
}
