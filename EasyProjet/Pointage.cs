//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyProjet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pointage
    {
        public int IdPointage { get; set; }
        public string ouverture_Session { get; set; }
        public string fermeture_session { get; set; }
        public string lance_tache { get; set; }
        public string ferme_tache { get; set; }
        public Nullable<int> idEmp { get; set; }
        public Nullable<int> tache { get; set; }
        public Nullable<int> tempTache { get; set; }
    
        public virtual Employe Employe { get; set; }
    }
}