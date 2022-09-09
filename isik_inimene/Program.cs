// See https://aka.ms/new-console-template for more information
using isik_inimene;

Tootaja tootaja = new Tootaja("Aleksei", 2000, Tootaja.sugu.isane, "TTHK", "Tarkvara", 1600);
Opilane opilane = new Opilane("Olesja", 2004, Opilane.sugu.emane, "Tallinna Kool", "LOGITpv20", ".");
Kutsekooliopilane kutseop = new Kutsekooliopilane("Maksim", 1983, Opilane.sugu.isane, "TTHK", "Designer", 3);
tootaja.print_Info();
opilane.print_Info();
kutseop.print_Info();

Tootaja tootaja1 = new Tootaja(tootaja);
Opilane opilane1 = new Opilane(opilane);
Kutsekooliopilane kutseop1 = new Kutsekooliopilane(kutseop);
muudaNimi();


void muudaNimi()
{ 
    Console.Write("\nKas sa tahad muuda nime?(ja või ei): \n");
    string vasta = Console.ReadLine();

    if (vasta == "ja")
    {
        Console.WriteLine("Kelle nime sa tahad muuta? (1-Tootaja,2-Õpilane,3-Kutsekooli õpilane)");
        int kes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Kirjuta uus nimi:");
        string vahetusNimi = Console.ReadLine();
        if (kes ==1)
        {
            tootaja1.muudaNimi(vahetusNimi);
            tootaja1.print_Info();
        }
        else if (kes == 2)
        {
            opilane1.muudaNimi(vahetusNimi);
            opilane1.print_Info();
        }
        else if (kes == 3)
        {
            kutseop1.muudaNimi(vahetusNimi);
            kutseop1.print_Info();
        }
    }
    else { Console.WriteLine("sa ei tahtnud nime muuta"); }
}