using C_sharp_Shop_2;

Prodotto biscotti = new Prodotto("Biscotti", "Senza glutine");
biscotti.StampaProdotto();

Acqua sorgesana = new Acqua("Sorgesana", "Naturale", 1, 7, "fiume");
sorgesana.StampaProdotto();
sorgesana.Riempi(0.5);
sorgesana.StampaProdotto();
sorgesana.Bevi(1);
sorgesana.StampaProdotto();
sorgesana.Svuota();
sorgesana.StampaProdotto();

SacchettoFrutta mela = new SacchettoFrutta("Mela", "Frutto dolciastro", 3, "Italia");
mela.StampaProdotto();
mela.Mangia(1);
mela.StampaProdotto();
mela.AggiungiFrutta(4);
mela.StampaProdotto();
mela.SvuotaSacchetto();
mela.StampaProdotto();

Elettrodomestico tritacarne = new Elettrodomestico("Tritacarne", "Serve a tritare la carne", 89.99, 10);
tritacarne.StampaProdotto();
tritacarne.Rotto();
tritacarne.StampaProdotto();

CiboInScatola tonno = new CiboInScatola("Tonno", "pesce sott'olio", 300);
tonno.StampaProdotto();
tonno.AperturaScatoletta();
tonno.Mangia(140);
tonno.StampaProdotto();
tonno.AggiungiCibo(25);
tonno.StampaProdotto();
tonno.SvuotaScatoletta();
tonno.StampaProdotto();

