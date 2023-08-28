using EF_DBFirst.Models;

namespace EF_DBFirst {
    internal class Program {
        static void Main(string[] args) {
            var _context = new GmprsContext();
            var users = _context.Users.ToList();
            foreach (var u in users) {
                Console.WriteLine($"{u.Lastname} | {u.Firstname}");
            }
        }
    }
}