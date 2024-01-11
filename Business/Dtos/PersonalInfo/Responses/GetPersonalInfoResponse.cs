﻿namespace Business.Dtos.PersonalInfo.Responses;

public class GetPersonalInfoResponse
{
    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public string? ProfileImageUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? NationalIdentity { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? Address { get; set; }
    public string? About { get; set; }
}
