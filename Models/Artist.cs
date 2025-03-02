﻿namespace P07_01_DI_Contactos_TAPIADOR_rodrigo.Models;

class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? Mbid { get; set; }
    public string? Artist_background { get; set; }
    public string? Artist_logo { get; set; }
    public string? Artist_thumbnail { get; set; }
    public string? Artist_banner { get; set; }
    public List<Album>? Albums { get; set; }

}
