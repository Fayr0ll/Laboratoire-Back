using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace API_LaboBack.Models.Client
{
    public class UserRegisterForm
    {
        public string Email { get; set; }
        public string MDP { get; set; }
        public string ConfirmMDP { get; set; }
    }
}
