// See https://aka.ms/new-console-template for more information
using isik_inimene;

Tootaja tootaja = new Tootaja("Aleksei", 2000, Tootaja.sugu.isane, "TTHK", "Tarkvara", 1600);
Opilane opilane = new Opilane("Olesja", 2004, Opilane.sugu.emane, "Tallinna Kool", "LOGITpv20", ".");
Kutsekooliopilane kutseop = new Kutsekooliopilane("Maksim", 1983, Opilane.sugu.isane, "TTHK", "Designer", 3);
tootaja.print_Info();
opilane.print_Info();
kutseop.print_Info();

