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



