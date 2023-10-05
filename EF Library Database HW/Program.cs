
using EF_Library_Database_HW.Contexts;

namespace EF_Library_Database_HW;


internal class Program {
    static void Main() {
        using LibraryDbContext context = new LibraryDbContext();
    }
}