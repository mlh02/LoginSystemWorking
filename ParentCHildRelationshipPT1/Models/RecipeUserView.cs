using System;
namespace ParentCHildRelationshipPT1.Models
{
    public class RecipeUserView
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string RecipeTimeToComplete { get; set; }


       
    }
}
