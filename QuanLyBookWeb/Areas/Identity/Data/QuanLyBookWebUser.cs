using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QuanLyBookWeb.Areas.Identity.Data;

// Add profile data for application users by adding properties to the QuanLyBookWebUser class
public class QuanLyBookWebUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName="nvarchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

}

