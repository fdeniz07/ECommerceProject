using Core.Application.Dtos;

namespace ECommerceProject.Api.Application.Dtos
{
    public class UserCreateDto:IDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public bool Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
    }
}


/*
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public bool Status { get; set; }
*/