//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace controle.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class proprietaire_c
    {
        public int id_proprio { get; set; }
        public string nom_proprio { get; set; }
        public int nbr_bien { get; set; }
        public System.DateTime date_creation_proprio { get; set; }
        public string nom_bien { get; set; }
    
        public virtual bien bien { get; set; }
    }
}
