using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.Classes
{
    // Class UserType
    class UserType
    {
        public int user_type_id { get; set; }
        public string user_type_name { get; set; }
    }

    // Class User 
    class User
    {
        public int user_id { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int user_type_id { get; set; }
        public DateTime date_of_birth { get; set; }
        public bool is_student { get; set; }
    }

    // Class Theatre 
    class Theatre
    {
        public int location_id { get; set; }
        public string location_name { get; set; }
        public string location_address { get; set; }
        public string location_phone { get; set; }
        public string location_photo { get; set; }
        public string business_hours { get; set; }
    }

    // Class Movie 
    class Movie
    {
        public int movie_id { get; set; }
        public string movie_title { get; set; }
        public int duration { get; set; }
        public string director_name { get; set; }
        public string photo_url { get; set; }
    }
    // Class Show 
    class Show
    {
        public int show_id { get; set; }
        public int location_id { get; set; }
        public int movie_id { get; set; }
        public int available_seats { get; set; }
        public DateTime date_time { get; set; }
    }
    // Class Ticket 
    class Ticket
    {
        public int ticket_id { get; set; }
        public int user_id { get; set; }
        public int show_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public DateTime order_date { get; set; }
        public decimal amount { get; set; }
    }
    // Class TicketPrice
    public class TicketPrice
    {
        public int location_id { get; set; }
        public decimal regular_price { get; set; }
        public decimal senior_discount { get; set; }
        public decimal student_discount { get; set; }
        public decimal member_discount { get; set; }
        public decimal admin_discount { get; set; }
        public decimal tuesday_discount { get; set; }
    }
}
