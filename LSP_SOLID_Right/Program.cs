// Recibe una interfaz de los animales que son cazadores
using LSP_SOLID_Right;

void GoToHunt(List<IHunt> hunters)
{
    // Ahora solo trabaja con todos los que sean cazadores
    foreach (var hunter in hunters)
    {
        hunter.Hunt();
    }
}

List<IHunt> listHunters = new List<IHunt>();
GoToHunt(listHunters);