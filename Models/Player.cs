using System.ComponentModel.DataAnnotations;

namespace ClickTheBox.API.Models
{
    public class Player
    {


        [Required, MaxLength(15)]
        public int Id { get; set; }

        [Required, MaxLength(25)]
        public string UserName { get; set; }

        public int CurrentAttemps { get; set; }



        public Player() { }

        public Player(int id, string userName, int currentAttemps)
        {
            Id = id;
            UserName = userName;
            CurrentAttemps = currentAttemps;
        }

    }
}
