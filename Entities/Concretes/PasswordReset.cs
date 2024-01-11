﻿using Core.Entities;
using Core.Entities.Concretes;

namespace Entities;

public class PasswordReset : Entity<Guid>
{
    public Guid? UserId { get; set; }
    public string? VerificationCode { get; set; }
    public bool? IsUsed { get; set; }

    public User? User { get; set; }
}
