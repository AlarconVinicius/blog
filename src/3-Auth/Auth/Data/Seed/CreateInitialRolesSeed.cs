﻿using Auth.Models;
using Microsoft.AspNetCore.Identity;

namespace Auth.Data.Seed;

public class CreateInitialRolesSeed
{
    private readonly ApplicationDbContext _context;

    public CreateInitialRolesSeed(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Create()
    {
        var rolesString = Enum.GetNames(typeof(RoleEnum));

        for (int i = 0; i < rolesString.Length; i++)
        {
            var role = rolesString[i];
            var domainRole = new IdentityRole()
            {
                Name = role,
                NormalizedName = role.ToUpper(),
                Id = Guid.NewGuid().ToString()
            };

            if (!_context.Roles.Any(x => x.NormalizedName == domainRole.NormalizedName))
            {
                _context.Roles.Add(domainRole);
            }
        }
        _context.SaveChanges();
    }
}
